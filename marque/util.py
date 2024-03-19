import builtins
import typing as t
from contextlib import contextmanager
from datetime import timedelta

import orjson
from pydantic import BaseModel

try:
    from pydantic import BaseModel
except ImportError:
    # Define a dummy BaseModel if pydantic isn't installed
    class BaseModel:  # type: ignore
        pass


def json_serialize(obj: t.Any) -> str:
    def custom_serializer(obj: t.Any) -> t.Any:
        if isinstance(obj, BaseModel):
            return obj.dict()
        return obj

    return orjson.dumps(obj, default=custom_serializer).decode()


def json_deserialize(obj: str) -> t.Any:
    return orjson.loads(obj)


# https://stackoverflow.com/questions/538666/format-timedelta-to-string
def format_timedelta(td_object: timedelta) -> str:
    # Convert the entire timedelta to milliseconds
    total_milliseconds = (
        td_object.days * 24 * 60 * 60 * 1000 + td_object.seconds * 1000 + td_object.microseconds // 1000
    )

    periods = [
        ("yr", 60 * 60 * 24 * 365 * 1000),
        ("mo", 60 * 60 * 24 * 30 * 1000),
        ("d", 60 * 60 * 24 * 1000),
        ("hr", 60 * 60 * 1000),
        ("m", 60 * 1000),
        ("s", 1000),
        ("ms", 1),
    ]

    strings = []
    for period_name, period_milliseconds in periods:
        if total_milliseconds >= period_milliseconds:
            period_value, total_milliseconds = divmod(total_milliseconds, period_milliseconds)
            strings.append(f"{period_value}{period_name}")

    return " ".join(strings) if strings else "~0ms"


@contextmanager
def PrintHook(log_func: t.Callable[[str], None]) -> t.Iterator[None]:
    original_print = builtins.print

    def custom_print(*args: t.Any, **kwargs: t.Any) -> None:
        log_message = " ".join(str(arg) for arg in args)
        log_func(log_message)

    builtins.print = custom_print

    try:
        yield
    finally:
        builtins.print = original_print
