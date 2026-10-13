# GenerationState

## Example Usage

```python
from meetkai_mka1.models import GenerationState

# Open enum: unrecognized values are captured as UnrecognizedStr
value: GenerationState = "pending"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"pending"`
- `"running"`
- `"publishing"`
- `"succeeded"`
- `"failed"`
- `"cancelling"`
- `"cancelled"`
