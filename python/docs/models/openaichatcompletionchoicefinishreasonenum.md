# OpenAIChatCompletionChoiceFinishReasonEnum

The reason why the model stopped generating tokens.

## Example Usage

```python
from meetkai_mka1.models import OpenAIChatCompletionChoiceFinishReasonEnum

# Open enum: unrecognized values are captured as UnrecognizedStr
value: OpenAIChatCompletionChoiceFinishReasonEnum = "stop"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"stop"`
- `"length"`
- `"tool_calls"`
- `"content_filter"`
