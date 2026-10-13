# EvalScheduleOverlapPolicy

## Example Usage

```python
from meetkai_mka1.models import EvalScheduleOverlapPolicy

# Open enum: unrecognized values are captured as UnrecognizedStr
value: EvalScheduleOverlapPolicy = "skip"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"skip"`
- `"buffer_one"`
- `"allow_all"`
