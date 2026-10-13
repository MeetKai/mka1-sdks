# EvalSampleStatus

## Example Usage

```python
from meetkai_mka1.models import EvalSampleStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: EvalSampleStatus = "queued"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"queued"`
- `"generating"`
- `"ready_to_score"`
- `"scoring"`
- `"running"`
- `"completed"`
- `"failed"`
