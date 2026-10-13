# GetExportStatusResponseStage

Current stage of the export process

## Example Usage

```python
from meetkai_mka1.models import GetExportStatusResponseStage

# Open enum: unrecognized values are captured as UnrecognizedStr
value: GetExportStatusResponseStage = "starting"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"starting"`
- `"fetching"`
- `"converting"`
- `"uploading"`
- `"completed"`
- `"failed"`
