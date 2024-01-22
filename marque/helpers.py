from marque.flow import StepFunc


def repeat(step: StepFunc | list[StepFunc], times: int) -> list[StepFunc]:
    steps = step if isinstance(step, list) else [step]
    return steps * times
