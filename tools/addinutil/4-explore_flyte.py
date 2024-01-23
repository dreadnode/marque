import sys

sys.path.append(".")

from addinutil.utils.tools import DotNetReversingTool
from addinutil.utils.metrics import Metrics, Judge, Dangerous
from addinutil.utils.prompts import Prompts
from addinutil.utils.generator import chat

from flytekit.experimental import eager

@eager
async def simple_evaluation(): 
    """Run a simple evaluation"""

    # get all methods in the System.Addin.dll assembly
    methods = await DotNetReversingTool.list_methods(file_name="addinutil/binaries/System.Addin.dll")
    
    # get a system prompt.
    system_prompt = await Prompts.get_system_prompt()

    # for each method, get a user prompt and run the generator
    for method in methods:
        user_prompt = await Prompts.prompt_dangerous_method(method=method)
        output = await chat(user_prompt=user_prompt, system_prompt=system_prompt, assistant_prefix="", max_tokens=2048, temperature=1)

        # send for scoring
        dangerous = await Dangerous.is_dangerous(llm_output=output)

    return dangerous
    
if __name__ == "__main__":
    print(simple_evaluation())
    
