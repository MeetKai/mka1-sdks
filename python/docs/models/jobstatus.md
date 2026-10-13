# JobStatus

## Example Usage

```python
from meetkai_mka1.models import JobStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: JobStatus = "validating_files"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"validating_files"`
- `"queued"`
- `"running"`
- `"succeeded"`
- `"failed"`
- `"cancelled"`
