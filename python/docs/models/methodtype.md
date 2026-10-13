# MethodType

## Example Usage

```python
from meetkai_mka1.models import MethodType

# Open enum: unrecognized values are captured as UnrecognizedStr
value: MethodType = "supervised"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"supervised"`
- `"dpo"`
- `"reinforcement"`
