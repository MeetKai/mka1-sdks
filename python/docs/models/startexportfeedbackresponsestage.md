# StartExportFeedbackResponseStage

Current stage of the export process

## Example Usage

```python
from meetkai_mka1.models import StartExportFeedbackResponseStage

# Open enum: unrecognized values are captured as UnrecognizedStr
value: StartExportFeedbackResponseStage = "starting"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"starting"`
- `"fetching"`
- `"converting"`
- `"uploading"`
- `"completed"`
- `"failed"`
