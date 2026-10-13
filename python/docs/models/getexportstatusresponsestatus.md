# GetExportStatusResponseStatus

Current status of the export job

## Example Usage

```python
from meetkai_mka1.models import GetExportStatusResponseStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: GetExportStatusResponseStatus = "UNKNOWN"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"UNKNOWN"`
- `"NOT_FOUND"`
- `"RUNNING"`
- `"COMPLETED"`
- `"FAILED"`
- `"CANCELLED"`
- `"TERMINATED"`
- `"CONTINUED_AS_NEW"`
- `"TIMED_OUT"`
