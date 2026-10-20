# StartExportFeedbackResponseStage

Current stage of the export process

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.StartExportFeedbackResponseStageStarting

// Open enum: custom values can be created with a direct type cast
custom := components.StartExportFeedbackResponseStage("custom_value")
```


## Values

| Name                                         | Value                                        |
| -------------------------------------------- | -------------------------------------------- |
| `StartExportFeedbackResponseStageStarting`   | starting                                     |
| `StartExportFeedbackResponseStageFetching`   | fetching                                     |
| `StartExportFeedbackResponseStageConverting` | converting                                   |
| `StartExportFeedbackResponseStageUploading`  | uploading                                    |
| `StartExportFeedbackResponseStageCompleted`  | completed                                    |
| `StartExportFeedbackResponseStageFailed`     | failed                                       |