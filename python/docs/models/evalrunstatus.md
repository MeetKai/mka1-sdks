# EvalRunStatus

## Example Usage

```python
from meetkai_mka1.models import EvalRunStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: EvalRunStatus = "queued"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"queued"`
- `"in_progress"`
- `"finalizing"`
- `"completed"`
- `"failed"`
- `"cancelling"`
- `"cancelled"`
