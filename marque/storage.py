import abc
import fnmatch
import pathlib
import typing as t

import orjson
import polars as pl

from marque.scope import Scope
from marque.util import json_deserialize, json_serialize


class Storage(abc.ABC):
    @abc.abstractmethod
    def save(self, scope: Scope) -> None:
        ...

    @abc.abstractmethod
    def load(self, id_: str) -> Scope:
        ...

    @abc.abstractmethod
    def get_ids(self) -> list[str]:
        ...

    @abc.abstractmethod
    def flush(self) -> None:
        ...

    @t.overload
    def search(
        self, pattern: str, only_latest: bool = True, only_ids: t.Literal[False] = False
    ) -> t.Generator[Scope, None, None]:
        ...

    @t.overload
    def search(self, pattern: str, only_latest: bool, only_ids: t.Literal[True]) -> list[str]:
        ...

    def search(
        self, pattern: str, only_latest: bool = True, only_ids: bool = False
    ) -> list[str] | t.Generator[Scope, None, None]:
        ids = [id_ for id_ in reversed(self.get_ids()) if fnmatch.fnmatch(id_, pattern)]
        if not ids:
            return []

        if only_latest:
            _, _, run_n, _ = ids[0].split(".")
            ids = [id_ for id_ in ids if id_.split(".")[2] == run_n]
        if only_ids:
            return ids
        return (self.load(id_) for id_ in ids)


class MemoryStorage(Storage):
    def __init__(self) -> None:
        self.scope: dict[str, Scope] = {}

    def save(self, scope: Scope) -> None:
        self.scope[scope.id] = scope

    def load(self, id_: str) -> Scope:
        return self.scope[id_]

    def get_ids(self) -> list[str]:
        return list(self.scope.keys())

    def flush(self) -> None:
        pass


class PolarsStorage(Storage):
    _schema: dict[str, type[pl.DataType]] = {
        "id": pl.String,
        # TODO: Using an Enum here would be preferred, but they get converted to categorical columns
        # when the file is pulled back from disk - no idea why
        "part": pl.String,
        "scope_duration": pl.Duration,
        "scope_error": pl.String,
        "artifact_name": pl.String,
        "artifact_value": pl.String,
        "tag_content": pl.String,
        "tag_value": pl.Float64,
    }

    def __init__(self, path: pathlib.Path | str):
        path = pathlib.Path(path)
        if path.suffix != ".parquet":
            raise ValueError(f"{path} should end in .parquet")

        self.path = path
        if self.path.exists():
            self.df = pl.read_parquet(self.path)
        else:
            self.df = pl.DataFrame(schema=self._schema)

    def flush(self) -> None:
        # We did a lot of isolated row writing - optimize for reading later
        self.df.rechunk()
        self.df.write_parquet(self.path)

    def save(self, scope: Scope) -> None:
        rows: list[dict[str, t.Any]] = [
            {
                "id": scope.id,
                "part": "scope",
                "scope_duration": scope.duration,
                "scope_error": scope.error,
                "artifact_name": None,
                "artifact_value": None,
                "tag_content": None,
                "tag_value": None,
            }
        ]

        for artifact in scope.artifacts:
            rows.append(
                {
                    "id": scope.id,
                    "part": "artifact",
                    "scope_duration": None,
                    "scope_error": None,
                    "artifact_name": artifact.name,
                    "artifact_value": json_serialize(artifact.value),
                    "tag_content": None,
                    "tag_value": None,
                }
            )

        for tag in scope.tags:
            rows.append(
                {
                    "id": scope.id,
                    "part": "tag",
                    "scope_duration": None,
                    "scope_error": None,
                    "artifact_name": None,
                    "artifact_value": None,
                    "tag_content": tag.content,
                    "tag_value": tag.value,
                }
            )

        row_df = pl.DataFrame(rows, schema=self._schema)
        self.df.vstack(row_df, in_place=True)

    def load(self, id_: str) -> Scope:
        search = self.df.filter(pl.col("id") == id_)
        if search.is_empty():
            raise KeyError(id_)

        scope = Scope(id_)
        for (
            _,
            part,
            scope_duration,
            scope_error,
            artifact_name,
            artifact_value,
            tag_content,
            tag_value,
        ) in search.iter_rows():
            if part == "scope":
                scope.duration = scope_duration
                scope.error = scope_error
            elif part == "artifact":
                scope.keep(artifact_name, json_deserialize(artifact_value), overwrite=True)
            elif part == "tag":
                scope.tag(tag_content, tag_value)
        return scope

    def get_ids(self) -> list[str]:
        return list(set(self.df["id"].to_list()))


class JsonStorage(Storage):
    def __init__(self, path: pathlib.Path | str):
        self.path = pathlib.Path(path)
        self.path.mkdir(parents=True, exist_ok=True)

    def save(self, scope: Scope) -> None:
        file_path = self.path / f"{scope.id}.json"
        with file_path.open("wb") as f:
            f.write(orjson.dumps(scope.to_json()))

    def load(self, id_: str) -> Scope:
        file_path = self.path / f"{id_}.json"
        if not file_path.exists():
            raise KeyError(id_)

        with file_path.open("rb") as f:
            data = t.cast(dict[str, t.Any], orjson.loads(f.read()))

        return Scope.from_json(data)

    def get_ids(self) -> list[str]:
        return [file.stem for file in self.path.glob("*.json")]

    def flush(self) -> None:
        pass
