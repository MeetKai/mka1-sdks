# OpenAIChatCompletionChoiceDetail

The detail level of the image analysis. 'low' disables high-res mode, 'high' enables it, 'auto' lets the model decide.

## Example Usage

```python
from meetkai_mka1.models import OpenAIChatCompletionChoiceDetail

# Open enum: unrecognized values are captured as UnrecognizedStr
value: OpenAIChatCompletionChoiceDetail = "auto"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"auto"`
- `"low"`
- `"high"`
