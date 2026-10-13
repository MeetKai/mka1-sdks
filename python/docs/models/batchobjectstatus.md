# BatchObjectStatus

## Example Usage

```python
from meetkai_mka1.models import BatchObjectStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: BatchObjectStatus = "validating"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"validating"`
- `"failed"`
- `"in_progress"`
- `"finalizing"`
- `"completed"`
- `"expired"`
- `"cancelling"`
- `"cancelled"`
