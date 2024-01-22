from tools import DotNetReversingTool

import ratline as rl

reversing_tool = DotNetReversingTool(valid_files=["AddInUtil.exe", "System.Addin.dll"])

study = rl.make_study("1-explore", "anthropic:model=claude-coast-1.0", max_iters=1)


@study.exp()
def list_methods(generator: rl.Generator) -> None:
    messages: list[rl.MessageDict] = [
        {"role": "user", "content": "List all methods contained in the 'AddInUtil.exe' assembly."}
    ]
    chat = generator.chat(messages).using(reversing_tool).run()
    rl.mark("correct" if "Main" in chat.last.content else "incorrect")
    rl.keep("messages", chat.all)


next_study = rl.make_study("2-process", max_iters=1)

# with all prior data at once
# for each prior trial -> create a trial here
# get - active data for this study
# recall - data from a prior study
# set - data for this study
# keep -
@next_study.exp_with("1-explore:list_methods", when_marks=lambda m: m == "correct")
def process_methods(generator: rl.Generator):
    previous = rl.recall[list[rl.Message]]("messages")
    pass

# maker(prior_study, prior_experiment,
@next_study.builder("1-explore", process_methods)
def make_thing(trials: list[rl.Trial]):
    pass
