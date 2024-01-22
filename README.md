# marque

marque (mark) is a minimal library for building workflows and pipelines in python. It has basic primitives for storing long-term data (`keep()/recall()`), passing runtime context (`put()/get()`), and dynamically extending the flow as it's executing (`push()`). 

- `Flow`: Defines the workflow and orchestrates it
- `Context`: Runtime object storage for flexible dependencies
- `Step`: Individual function in the workflow
- `Scope`: A storage object provided to each step for artifacts/tagging
    - `Tag`: A `str, float | None` pair you can use to label a scope
    - `Artifact`: Arbitrary data you want to keep and recall later

The output of a flow is essentially a set of `Scope` objects which represent all the important data generated during the workflow run. You can use the `search()` function to find prior scopes and use their data to prepare new steps.

Here is a basic example:

```python
from random import Random

from marque import Flow, repeat
from marque.storage import PolarsStorage


def add(flow: Flow):
    a, b = flow.get(int, ["a", "b"])            # pull values from the current context
    flow.tag(f"{a} + {b}")                      # add tags for faster analytics/filtering
    flow.keep("data", {"answer": a + b})        # persist data to recall later

def sub(flow: Flow):
    a, b = flow.get(int, ["a", "b"])
    flow.tag(f"{a} - {b}")
    flow.keep("data", {"answer": a - b})

def simple_math(flow: Flow):
    random = flow.get(Random)           # pull context values using only types

    a = random.randint(10, 100)
    b = random.randint(10, 100)

    flow.push(
        random.choice([add, sub]),      # extend the workflow with a new step
        a=a, b=b                        # pass required context values
    )

def inspect_add(flow: Flow):
    for scope in flow.search(                       # search prior scopes and filter
        "*",                                        # glob syntax is supported
        where=lambda tag: "+" in tag.content
    ):
        for tag in scope.tags:
            flow.log(tag.content)

def inspect_sub(flow: Flow):
    for scope in flow.search(sub):                  # or just pass the function
        flow.log(scope.recall("data")["answer"])    # and pull data from the scope

flow = (
    Flow("test", PolarsStorage("test.parquet"))     # persist data to a parquet file
    .fail_fast()                                    # don't ignore errors
    .put(random=Random(42))                         # prepare a seeded random generator
    .push(repeat(simple_math, 5))                   # add 5 steps for simple_math
    .push([inspect_add, inspect_sub])               # run after everything else
)

flow()                 # Execute our flow

print(flow.run)        # The run id (2-part slug)
print(flow.logs)       # list of any logs
print(flow.scopes)     # list of all scopes
print(flow.errors)     # any errors if we don't fail_fast

```