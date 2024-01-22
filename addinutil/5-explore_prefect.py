from prefect import Flow, task

from addinutil.utils.tools import DotNetReversingTool
from addinutil.utils.metrics import Metrics, Judge, Dangerous
from addinutil.utils.prompts import Prompts
from addinutil.utils.generator import chat

@task
def list_methods():
    methods = DotNetReversingTool.list_methods(file_name="addinutil/binaries/System.Addin.dll")
    return methods

@task
def evaluate_method(method):
    system_prompt = Prompts.get_system_prompt()
    user_prompt = Prompts.prompt_dangerous_method(method=method)
    output = chat(user_prompt=user_prompt, system_prompt=system_prompt, assistant_prefix="", max_tokens=2048, temperature=1)
    dangerous = Dangerous.is_dangerous(llm_output=output)
    return method, dangerous

with Flow("Simple Evaluation Flow") as flow:
    methods = list_methods()
    evaluations = evaluate_method.map(methods)

if __name__ == "__main__":
    flow.run()
