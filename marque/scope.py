import datetime
import typing as t
from dataclasses import dataclass

from pydantic import TypeAdapter

if t.TYPE_CHECKING:
    from datetime import timedelta


@dataclass
class Tag:
    content: str
    value: float | None = None

    def __repr__(self) -> str:
        return f"<Tag content={self.content} value={self.value}>"


@dataclass
class Artifact:
    name: str
    value: dict[str, t.Any]

    def __repr__(self) -> str:
        return f"<Artifact name={self.name}>"


class Scope:
    def __init__(self, id_: str):
        self.id = id_
        self.tags: list[Tag] = []
        self.artifacts: list[Artifact] = []
        self.error: str | None = None
        self.duration: timedelta | None = None

    def __repr__(self) -> str:
        return f"<Scope id={self.id} tag_count={len(self.tags)} artifact_count={len(self.artifacts)}>"

    # TODO: This could probably get pulled out to the utils
    # module and rework these as BaseModels or dataclasses

    def to_json(self) -> dict[str, t.Any]:
        artifact_adapter = TypeAdapter(Artifact)
        tag_adapter = TypeAdapter(Tag)

        return {
            "id": self.id,
            "tags": [tag_adapter.dump_python(tag) for tag in self.tags],
            "artifacts": [artifact_adapter.dump_python(artifact) for artifact in self.artifacts],
            "error": self.error,
            "duration": self.duration.microseconds if self.duration else None,
        }

    @classmethod
    def from_json(cls, data: dict[str, t.Any]) -> "Scope":
        artifact_adapter = TypeAdapter(Artifact)
        tag_adapter = TypeAdapter(Tag)

        scope = cls(data["id"])
        scope.tags = [tag_adapter.validate_python(tag) for tag in data["tags"]]
        scope.artifacts = [artifact_adapter.validate_python(artifact) for artifact in data["artifacts"]]
        scope.error = data["error"]
        scope.duration = datetime.timedelta(microseconds=data["duration"]) if data["duration"] else None

        return scope

    def keep(self, name: str, value: dict[str, t.Any], overwrite: bool = False) -> "Scope":
        if not isinstance(value, dict):
            raise TypeError(f"{value} is not a dict.")

        for existing in self.artifacts:
            if existing.name == name:
                if overwrite:
                    existing.value = value
                    break
                else:
                    raise KeyError(f"{name} already exists.")
        else:
            self.artifacts.append(Artifact(name, value))

        return self

    def recall(self, name: str) -> dict[str, t.Any]:
        for existing in self.artifacts:
            if existing.name == name:
                return existing.value
        raise KeyError(name)

    def tag(self, content: str, value: float | None = None) -> "Scope":
        # Should we force uniqueness?
        # for mname, _ in self.tags:
        #     if mname == name:
        #         raise KeyError(f"{name} marker already stored.")
        self.tags.append(Tag(content, value))
        return self
