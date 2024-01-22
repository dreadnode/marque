import luigi
from addinutil.utils.tools import DotNetReversingTool
from addinutil.utils.metrics import Metrics, Judge, Dangerous
from addinutil.utils.prompts import Prompts
from addinutil.utils.generator import chat

class ListMethodsTask(luigi.Task):
    def requires(self):
        return None

    def run(self):
        methods = DotNetReversingTool.list_methods(file_name="addinutil/binaries/System.Addin.dll")
        with self.output().open('w') as f:
            for method in methods:
                f.write(method + '\n')

    def output(self):
        return luigi.LocalTarget('methods.txt')

class EvaluateMethodsTask(luigi.Task):
    def requires(self):
        return ListMethodsTask()

    def run(self):
        with self.input().open('r') as f:
            methods = f.read().splitlines()

        system_prompt = Prompts.get_system_prompt()
        results = []

        for method in methods:
            user_prompt = Prompts.prompt_dangerous_method(method=method)
            output = chat(user_prompt=user_prompt, system_prompt=system_prompt, assistant_prefix="", max_tokens=2048, temperature=1)
            dangerous = Dangerous.is_dangerous(llm_output=output)
            results.append((method, dangerous))

        with self.output().open('w') as f:
            for method, result in results:
                f.write(f"{method}: {result}\n")

    def output(self):
        return luigi.LocalTarget('evaluation_results.txt')

if __name__ == "__main__":
    luigi.run(['EvaluateMethodsTask', '--local-scheduler'])
