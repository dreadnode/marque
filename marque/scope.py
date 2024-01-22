import typing as t
from dataclasses import dataclass

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
        return f"<Scope id={self.id}>"

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
