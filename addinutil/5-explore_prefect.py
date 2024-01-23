import typing as t

from addinutil.utils.tools import DotNetReversingTool
from addinutil.utils.metrics import Metrics, Judge, Dangerous
from addinutil.utils.prompts import Prompts
from addinutil.utils.generator import chat

from prefect import flow, task
from prefect.artifacts import create_markdown_artifact
from prefect.artifacts import create_table_artifact

from time import sleep

@task
def markdown_report(results):
    markdown_report = f"""# Summary Report

## Results
| Function | Dangerous |
|:---------|:---------:|
"""

    for result in results:
        markdown_report += f"| {result['method']} | {result['dangerous']} |\n"

    create_markdown_artifact(key="results", markdown=markdown_report)


@task
def markdown_report_2(results):
    markdown_report = f"""# Summary Report

## Results
{results}
"""
    create_markdown_artifact(key="results", markdown=markdown_report)


@task
def table_report(results):
    create_table_artifact(key="results", table=results)


@task
def check_dangerous(llm_output):
    dangerous = Dangerous.is_dangerous(llm_output)
    return dangerous

@task
def get_chat_output(user_prompt, system_prompt):
    sleep(2)
    output = chat(user_prompt=user_prompt, system_prompt=system_prompt, assistant_prefix="", max_tokens=2048, temperature=1)
    return output

@task
def get_system_prompt():
    system_prompt = Prompts.get_system_prompt()
    return system_prompt

@task
def get_user_prompt(method):
    user_prompt = Prompts.prompt_dangerous_method(method)
    return user_prompt

@task
def get_vuln_function_prompt(code, assembly_name, vuln_function):
    user_prompt = Prompts.prompt_vuln_function(code=code, assembly_name=assembly_name, vuln_function=vuln_function)
    return user_prompt

@task
def decompile_method(file_name, method_name):
    method = DotNetReversingTool.decompile_method(file_name=file_name, method_name=method_name)
    return method

@task
def decompile_all(file_name):
    assembly = DotNetReversingTool.decompile_all(file_name=file_name)
    return assembly

@task
def list_methods(file_name):
    methods = DotNetReversingTool.list_methods(file_name)
    return methods

@flow(name="Find Dangerous Method", log_prints=True)
def simple_evaluation(assemblies: t.List[str]):
    results = []
    system_prompt = get_system_prompt()

    for assembly in assemblies:
        methods = list_methods(assembly)

        for method in methods:
            user_prompt = get_user_prompt(method=method)
            output = get_chat_output(user_prompt=user_prompt, system_prompt=system_prompt)
            dangerous = check_dangerous(llm_output=output)
            results.append({"method": method, "dangerous": dangerous})

            if dangerous:
                more_advanced_evaluation(assembly, method)
    
    table_report(results)
    markdown_report(results)


@flow(name="Examine Dangerous Function", log_prints=True)
def more_advanced_evaluation(file_name, method):
    print(f"This function is dangerous:{method}")
    method = decompile_method(file_name, method)
    whole_assembly = decompile_all(file_name)
    user_prompt = get_vuln_function_prompt(code=whole_assembly, assembly_name=file_name, vuln_function=method)
    system_prompt = get_system_prompt()

    output = get_chat_output(user_prompt=user_prompt, system_prompt=system_prompt)

    markdown_report_2(output)


@flow(name="Generate Payload", log_prints=True)
def generate_payload():
    pass

if __name__ == "__main__":
    simple_evaluation(["addinutil/binaries/System.Addin.dll"])
