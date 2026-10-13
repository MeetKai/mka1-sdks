# GuardrailMode

## Example Usage

```python
from meetkai_mka1.models import GuardrailMode

# Open enum: unrecognized values are captured as UnrecognizedStr
value: GuardrailMode = "ban_words"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"ban_words"`
- `"prompt_injection"`
- `"leakage"`
- `"classifier"`
