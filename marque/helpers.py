import functools
import traceback

from marque.flow import Flow, StepFunc


def repeat(step: StepFunc | list[StepFunc], times: int) -> list[StepFunc]:
    steps = step if isinstance(step, list) else [step]
    return steps * times


# TODO: We should probably integrate this better with the flow
# management and handle storing errored scopes for inspection
# if we need them.


def retry(step: StepFunc, max_times: int) -> StepFunc:
    @functools.wraps(step)
    def _retry(flow: Flow) -> None:
        max_times_str = "inf" if max_times == -1 else str(max_times)
        i = 0
        while max_times == -1 or i < max_times:
            try:
                flow.log(f"  |: Attempting {step.__name__} [{i+1}/{max_times_str}]")
                return step(flow)
            except Exception:
                if max_times != -1 and i == max_times - 1:
                    flow.error(f"  |: Exceeded max attempts ({max_times}) for {step.__name__}")
                    raise
                flow.error(f"  |: {traceback.format_exc()}")
                pass
            i += 1

    return _retry
