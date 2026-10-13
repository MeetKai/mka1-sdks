# RunInfoStatus

## Example Usage

```python
from meetkai_mka1.models import RunInfoStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: RunInfoStatus = "RUNNING"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"RUNNING"`
- `"SCHEDULED"`
- `"FINISHED"`
- `"FAILED"`
- `"KILLED"`
