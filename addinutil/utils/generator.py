# Anthropic helpers

import os
import anthropic
from anthropic import Anthropic, HUMAN_PROMPT, AI_PROMPT

HELPFUL_MODEL = "claude-coast-1.0"

anthropic = Anthropic(
    api_key=os.environ["ANTHROPIC_API_KEY"],
)

def chat(
    user_prompt: str,
    system_prompt: str = "",
    assistant_prefix: str = "",
    max_tokens: int = 2048,
    temperature: int = 1,
) -> str:
    prompt = f"{system_prompt} " if system_prompt else ""
    prompt += f"{HUMAN_PROMPT} {user_prompt}{AI_PROMPT} "
    result = anthropic.completions.create(
        model=HELPFUL_MODEL,
        max_tokens_to_sample=max_tokens,
        temperature=temperature,
        prompt=f'{prompt}{assistant_prefix}',
    )
    return result.completion.strip()