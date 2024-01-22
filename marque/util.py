import typing as t

import orjson

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
