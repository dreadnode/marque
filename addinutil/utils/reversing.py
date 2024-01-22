import os
import pathlib
import sys

#
# Fair warning, this file is a mess on the part of .NET interop. Order matters here.
#

os.environ["DOTNET_ROOT"] = os.environ["HOME"] + "/.dotnet"
os.environ["PATH"] += ":" + os.environ["DOTNET_ROOT"] + ":" + os.environ["DOTNET_ROOT"] + "/tools"
os.environ["PYTHONNET_RUNTIME"] = "coreclr"

import clr  # type: ignore

clr_dir = pathlib.Path(__file__).parent / "clr"
sys.path.append(str(clr_dir))

clr.AddReference("ICSharpCode.Decompiler")  # type: ignore [attr-defined]
clr.AddReference("Mono.Cecil")  # type: ignore [attr-defined]

from ICSharpCode.Decompiler import DecompilerSettings
from ICSharpCode.Decompiler.CSharp import CSharpDecompiler
from ICSharpCode.Decompiler.Metadata import MetadataTokenHelpers
from Mono.Cecil import AssemblyDefinition


def _get_decompiler(path: pathlib.Path) -> CSharpDecompiler:
    settings = DecompilerSettings()
    settings.ThrowOnAssemblyResolveErrors = False
    return CSharpDecompiler(str(path), settings)


def decompile_all(path: pathlib.Path) -> str:
    return _get_decompiler(path).DecompileWholeModuleAsString()  # type: ignore [no-any-return]


def decompile_type(path: pathlib.Path, type_name: str) -> str:
    return _get_decompiler(path).DecompileTypeAsString(type_name)  # type: ignore [no-any-return]


def decompile_token(path: pathlib.Path, token: int) -> str:
    entity_handle = MetadataTokenHelpers.TryAsEntityHandle(token.ToUInt32())  # type: ignore [attr-defined]
    return _get_decompiler(path).DecompileAsString(entity_handle)  # type: ignore [no-any-return]


def decompile_method(path: pathlib.Path, method_name: str) -> str:
    assembly = AssemblyDefinition.ReadAssembly(str(path))

    for module in assembly.Modules:
        for module_type in module.Types:
            for method in module_type.Methods:
                if method_name not in [method.FullName, method.Name]:
                    continue
                return decompile_token(path, method.MetadataToken)
    else:
        raise ValueError(f"Method '{method_name}' not found in '{path}'")


def list_types(path: pathlib.Path) -> list[str]:
    assembly = AssemblyDefinition.ReadAssembly(str(path))
    types: list[str] = []
    for module in assembly.Modules:
        for module_type in module.Types:
            types.append(module_type.FullName)
    return types


def list_methods(path: pathlib.Path) -> list[str]:
    assembly = AssemblyDefinition.ReadAssembly(str(path))
    methods: list[str] = []
    for module in assembly.Modules:
        for module_type in module.Types:
            for method in module_type.Methods:
                methods.append(method.FullName)
    return methods


def find_references(path: pathlib.Path, search: str) -> list[str]:
    assembly = AssemblyDefinition.ReadAssembly(str(path))

    flexible_search_strings = [search.lower(), search.lower().replace(".", "::"), search.lower().replace("::", ".")]

    using_methods: list[str] = []
    for module in assembly.Modules:
        methods = []
        for module_type in module.Types:
            for method in module_type.Methods:
                methods.append(method)

        for method in methods:
            if not method.HasBody:
                continue

            for instruction in method.Body.Instructions:
                intruction_str = str(instruction.Operand).lower()
                for search in flexible_search_strings:
                    if search in intruction_str:
                        using_methods.append(method.FullName)

    return list(set(using_methods))
