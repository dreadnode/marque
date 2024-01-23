import pathlib
import typing as t

from . import reversing

#import decompile_all, decompile_method, find_references, list_methods


class DotNetReversingTool():
    @property
    def name(self) -> str:
        return "dotnet-reversing"

    @property
    def description(self) -> str:
        return "Reverse and explore .NET assemblies"

    @staticmethod
    def list_methods(file_name: t.Annotated[str, "Name of the .NET assembly"]) -> t.List[str]:
        """List all methods contained in an assembly"""
        return reversing.list_methods(pathlib.Path(file_name))

    @staticmethod

    def find_references_to(
        file_name: t.Annotated[str, "Name of the .NET assembly"],
        search: t.Annotated[str, "Reference search string"],
    ) -> str:
        """Find all methods that reference a given method"""
        return "\n".join(reversing.find_references(file_name, search))

    @staticmethod
    def decompile_method(
        file_name: t.Annotated[str, "Name of the .NET assembly"],
        method_name: t.Annotated[str, "Method name to decompile"],
    ) -> str:
        """Decompile a method in an assembly"""
        return reversing.decompile_method(file_name, method_name)

    @staticmethod
    def decompile_all(
        file_name: t.Annotated[str, "Name of the .NET assembly"],
    ) -> str:
        """Decompile all types and methods in an assembly"""
        return reversing.decompile_all(file_name)
