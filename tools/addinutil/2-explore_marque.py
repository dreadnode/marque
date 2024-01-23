from marque import Flow
from marque.storage import PolarsStorage

from utils.tools import DotNetReversingTool
from utils.metrics import Metrics, Judge, Dangerous
from utils.prompts import Prompts
from addinutil.utils.generator import chat


def flow_chat(flow: Flow):
    user_prompt = flow.get(str, "user_prompt")
    system_prompt = flow.get(str, "system_prompt")

    output = chat(user_prompt=user_prompt, system_prompt=system_prompt, assistant_prefix="", max_tokens=2048, temperature=1)

    flow.put(output=output)

def check_dangerous(flow: Flow):
    user_prompt = flow.get(str, "user_prompt")
    system_prompt = flow.get(str, "system_prompt")
    output = flow.get(str, "output")

    dangerous = Dangerous.is_dangerous(llm_output=output)

    dangerous_dict = {
        "user_prompt": user_prompt,
        "system_prompt": system_prompt,
        "output": output,
        "dangerous": dangerous
    }

    flow.keep("result", dangerous_dict)


evaluation = (
    Flow("addinutil_evaluation", PolarsStorage("addinutil_evaluation.parquet"))
    .fail_fast()
    .put(tool=DotNetReversingTool.list_methods(file_name="addinutil/binaries/System.Addin.dll"))
    .put(system_prompt=Prompts.get_system_prompt())
    .put(user_prompt=Prompts.prompt_dangerous_method(method="System.Addin.dll"))
    .push(flow_chat)
    .push(check_dangerous)
)

evaluation()


print(evaluation.run)        # The run id (2-part slug)
print(evaluation.logs)       # list of any logs
print(evaluation.scopes)     # list of all scopes
print(evaluation.errors)     # any errors if we don't fail_fast