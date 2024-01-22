import inspect
import traceback
import typing as t
from dataclasses import dataclass
from datetime import datetime

import coolname  # type: ignore [import-untyped]
from loguru import logger

from marque.scope import Scope, Tag
from marque.storage import MemoryStorage, Storage
from marque.util import LogLevelLiteral, configure_logging, format_timedelta

T = t.TypeVar("T")

StepFunc = t.Callable[["Flow"], None]


class Context:
    def __init__(self, parent: t.Optional["Context"] = None) -> None:
        self.objects: list[tuple[type, t.Any, str | None]] = []
        self.parent = parent

    def put(self, **values: t.Any) -> "Context":
        cache = self
        for key, value in values.items():
            cache = cache._put(type(value), value, key)
        return cache

    def _put(self, type_: type[T], obj: T, id_: str | None = None) -> "Context":
        if not isinstance(obj, type_):
            raise TypeError(f"{obj} is not a {type_.__name__}.")

        for otype, _, oname in self.objects:
            if otype == type_ and (id_ is None or oname == id_):
                new_cache = Context(self)
                new_cache._put(type_, obj, id_)
                return new_cache

        self.objects.append((type_, obj, id_))
        return self

    @t.overload
    def get(self, type_: type[T], id_: str | None = None, strict: t.Literal[True] = True) -> T:
        ...

    @t.overload
    def get(self, type_: type[T], id_: str | None = None, strict: t.Literal[False] = ...) -> T | None:
        ...

    @t.overload
    def get(self, type_: type[T], id_: list[str], strict: t.Literal[True] = True) -> tuple[T, ...]:
        ...

    @t.overload
    def get(self, type_: type[T], id_: list[str], strict: t.Literal[False] = ...) -> tuple[T | None, ...]:
        ...

    def get(
        self, type_: type[T], id_: str | list[str] | None = None, strict: bool = True
    ) -> T | None | tuple[T | None, ...]:
        if isinstance(id_, list):
            return tuple(self._get(type_, single_id, strict) for single_id in id_)
        else:
            return self._get(type_, id_, strict)

    def _get(self, type_: type[T], id_: str | None = None, strict: bool = True) -> T | None:
        matching = [(oid, oval) for otype, oval, oid in self.objects if issubclass(otype, type_)]
        if len(matching) == 0:
            if self.parent is not None:
                return self.parent._get(type_, id_)
            elif strict:
                raise KeyError(f"{type_.__name__} with id '{id_}'" or type.__name__)
            else:
                return None

        if id_ is None:
            if len(matching) == 1:
                return matching[0][1]  # type: ignore
            else:
                raise ValueError(
                    f"Multiple {type_.__name__} objects exist. Use a specific id to get one of the values."
                )

        for tid, tval in matching:
            if tid == id_:
                return tval  # type: ignore
        if self.parent is not None:
            return self.parent._get(type_, id_)
        elif strict:
            raise KeyError(f"{type.__name__} with id '{id_}'")
        else:
            return None


@dataclass
class Step:
    func: StepFunc
    context: Context
    scope: Scope
    logs: list[str]
    ref_scope: Scope | None = None

    @property
    def name(self) -> str:
        return self.func.__name__

    def __init__(self, func: StepFunc, context: Context, get_scope_id: t.Callable[["Step"], str]):
        self.func = func
        self.context = context
        self.logs = []
        self.scope = Scope(get_scope_id(self))

    def __repr__(self) -> str:
        return f"<Step func={self.func.__name__} scope={self.scope!r} ref_scope={self.ref_scope!r}>"


class Flow:
    def __init__(self, name: str, storage: Storage | None = None, log_level: LogLevelLiteral = "INFO"):
        self.name = name
        self.run = coolname.generate_slug(2)
        self.state: t.Literal["pending", "running", "finished"] = "pending"
        self.storage = storage or MemoryStorage()
        self.context: Context = Context()
        self.tags: list[Tag] = []
        self.steps: list[list[Step]] = []
        self.step_idx = 0
        self.group_idx = 0
        self.current: Step | None = None
        self.ignore_errors: bool = True
        self.log_level = log_level

    def _validate_step_func(self, step: StepFunc) -> None:
        signature = inspect.signature(step)
        if len(signature.parameters) != 1 or list(signature.parameters.values())[0].annotation != Flow:
            raise ValueError(f"Step functions must take exactly one argument (a Flow object) ({step.__name__}).")
        if signature.return_annotation not in [None, inspect.Signature.empty]:
            raise ValueError(f"Step functions must not return any values ({step.__name__}).")

    @property
    def errors(self) -> list[tuple[str, str]]:
        if self.state != "finished":
            raise RuntimeError(f"Flow is not finished yet (state={self.state}).")
        return [(step.scope.id, step.scope.error) for group in self.steps for step in group if step.scope.error]

    @property
    def scopes(self) -> list[Scope]:
        return [step.scope for group in self.steps for step in group]

    @property
    def logs(self) -> list[str]:
        return [log for group in self.steps for step in group for log in step.logs]

    def put(self, **values: t.Any) -> "Flow":
        context = self.current.context if self.current is not None else self.context
        context.put(**values)
        return self

    @t.overload
    def get(self, type_: type[T], id_: str | None = None, strict: t.Literal[True] = True) -> T:
        ...

    @t.overload
    def get(self, type_: type[T], id_: str | None = None, strict: t.Literal[False] = ...) -> T | None:
        ...

    @t.overload
    def get(self, type_: type[T], id_: list[str], strict: t.Literal[True] = True) -> tuple[T, ...]:
        ...

    @t.overload
    def get(self, type_: type[T], id_: list[str], strict: t.Literal[False] = ...) -> tuple[T | None, ...]:
        ...

    def get(
        self, type_: type[T], id_: str | list[str] | None = None, strict: bool = True
    ) -> T | None | tuple[T | None, ...]:
        context = self.current.context if self.current is not None else self.context
        return context.get(type_, id_, strict)  # type: ignore

    def keep(self, name: str, artifact: dict[str, t.Any], overwrite: bool = False) -> "Flow":
        if self.current is None:
            raise RuntimeError("Cannot keep() outside of a running step.")
        self.current.scope.keep(name, artifact, overwrite)
        return self

    def recall(self, name: str) -> dict[str, t.Any]:
        if self.current is None:
            raise RuntimeError("Cannot recall() outside of a running step.")
        scope = self.current.ref_scope or self.current.scope
        return scope.recall(name)

    def tag(self, content: str, value: float | None = None) -> "Flow":
        if self.current is None:
            self.tags.append(Tag(content, value))
        else:
            self.current.scope.tag(content, value)
        return self

    def log(self, msg: str) -> "Flow":
        if self.current is None:
            raise RuntimeError("Cannot log() outside of a running step.")
        self.current.logs.append(msg)
        return self

    def push_with_scope(self, step: StepFunc | list[StepFunc], scope: Scope | None = None, **context: t.Any) -> "Flow":
        step_objects: list[Step] = []
        for step_func in step if isinstance(step, list) else [step]:
            self._validate_step_func(step_func)
            step_obj = Step(
                step_func,
                Context(self.context).put(**context) if context else self.context,
                lambda step: f"{self.name}.{step.name}.{self.run}.{coolname.generate_slug(2)}",
            )
            step_obj.ref_scope = scope
            step_objects.append(step_obj)

        if self.current is not None:
            self.steps[self.group_idx] += step_objects
            for step_obj in step_objects:
                logger.info(f"  |+ New '{step_obj.name}' step added")
        else:
            self.steps.append(step_objects)

        return self

    def push(self, step: StepFunc | list[StepFunc], **context: t.Any) -> "Flow":
        return self.push_with_scope(step, scope=None, **context)

    def search(
        self, pattern_or_step: str | StepFunc, where: t.Callable[[Tag], bool] | None = None
    ) -> t.Generator[Scope, None, None]:
        pattern = pattern_or_step if isinstance(pattern_or_step, str) else f"{self.name}.{pattern_or_step.__name__}.*"
        for scope in self.storage.search(pattern):
            if where is None or any(where(tag) for tag in scope.tags):
                yield scope

    def fail_fast(self) -> "Flow":
        self.ignore_errors = False
        return self

    def __call__(self) -> None:
        if self.state != "pending":
            raise RuntimeError(f"Flow is already in '{self.state}' state.")

        configure_logging(self.log_level)

        logger.success("")
        logger.success(f"Starting flow '{self.name}' / '{self.run}'")
        logger.success("")

        self.state = "running"

        while self.group_idx < len(self.steps):
            self.step_idx = 0
            while self.step_idx < len(self.steps[self.group_idx]):
                self.current = self.steps[self.group_idx][self.step_idx]
                logger.info(f"> Step '{self.current.name}' ({self.group_idx}:{self.step_idx})")

                start = datetime.now()

                try:
                    self.current.func(self)
                except Exception:
                    if self.ignore_errors:
                        self.current.scope.error = traceback.format_exc()
                        logger.error(f"  |: {self.current.scope.error}")
                    else:
                        raise

                for log in self.current.logs:
                    logger.info(f"  |: {log}")

                self.current.scope.duration = datetime.now() - start
                logger.info(f"  |- in {format_timedelta(self.current.scope.duration)}")
                logger.info("")
                self.storage.save(self.current.scope)

                self.step_idx += 1
            self.group_idx += 1

        self.storage.flush()
        self.state = "finished"

        logger.success("")
        logger.success(f"Finished flow '{self.name}' / '{self.run}'")
        logger.success("")
