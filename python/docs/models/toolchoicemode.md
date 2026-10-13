# ToolChoiceMode

Tool choice mode: Selects how the model decides tool usage. Use none, auto, or required.

## Example Usage

```python
from meetkai_mka1.models import ToolChoiceMode

# Open enum: unrecognized values are captured as UnrecognizedStr
value: ToolChoiceMode = "none"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"none"`
- `"auto"`
- `"required"`
