# GetExportStatusResponseStage

Current stage of the export process

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.GetExportStatusResponseStageStarting

// Open enum: custom values can be created with a direct type cast
custom := components.GetExportStatusResponseStage("custom_value")
```


## Values

| Name                                     | Value                                    |
| ---------------------------------------- | ---------------------------------------- |
| `GetExportStatusResponseStageStarting`   | starting                                 |
| `GetExportStatusResponseStageFetching`   | fetching                                 |
| `GetExportStatusResponseStageConverting` | converting                               |
| `GetExportStatusResponseStageUploading`  | uploading                                |
| `GetExportStatusResponseStageCompleted`  | completed                                |
| `GetExportStatusResponseStageFailed`     | failed                                   |