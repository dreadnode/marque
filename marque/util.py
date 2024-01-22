import pathlib
import sys
import typing as t
from datetime import timedelta

import orjson
from pydantic import BaseModel

try:
    from pydantic import BaseModel  # type: ignore
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


LogLevelList = ["TRACE", "DEBUG", "INFO", "SUCCESS", "WARNING", "ERROR", "CRITICAL"]
LogLevelLiteral = t.Literal["TRACE", "DEBUG", "INFO", "SUCCESS", "WARNING", "ERROR", "CRITICAL"]


def configure_logging(
    log_level: str, log_file: pathlib.Path | None = None, log_file_level: LogLevelLiteral = "DEBUG"
) -> None:
    from loguru import logger

    logger.level("TRACE", color="<magenta>", icon="[T]")
    logger.level("DEBUG", color="<blue>", icon="[_]")
    logger.level("INFO", color="<cyan>", icon="[=]")
    logger.level("SUCCESS", color="<green>", icon="[+]")
    logger.level("WARNING", color="<yellow>", icon="[-]")
    logger.level("ERROR", color="<red>", icon="[!]")
    logger.level("CRITICAL", color="<RED>", icon="[x]")

    # Default format:
    # "<green>{time:YYYY-MM-DD HH:mm:ss.SSS}</green> | "
    # "<level>{level: <8}</level> | "
    # "<cyan>{name}</cyan>:<cyan>{function}</cyan>:<cyan>{line}</cyan> - <level>{message}</level>",

    custom_format = "<level>{level.icon}</level> {message}"

    logger.remove()
    logger.add(sys.stderr, format=custom_format, level=log_level)

    if log_file is not None:
        logger.add(log_file, format=custom_format, level=log_file_level)
        logger.info(f"Logging to {log_file}")

    g_logging_configured = True


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
