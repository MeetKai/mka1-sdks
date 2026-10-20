# StartExportFeedbackResponseStatus

Current status of the export job

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.StartExportFeedbackResponseStatusUnknown

// Open enum: custom values can be created with a direct type cast
custom := components.StartExportFeedbackResponseStatus("custom_value")
```


## Values

| Name                                              | Value                                             |
| ------------------------------------------------- | ------------------------------------------------- |
| `StartExportFeedbackResponseStatusUnknown`        | UNKNOWN                                           |
| `StartExportFeedbackResponseStatusNotFound`       | NOT_FOUND                                         |
| `StartExportFeedbackResponseStatusRunning`        | RUNNING                                           |
| `StartExportFeedbackResponseStatusCompleted`      | COMPLETED                                         |
| `StartExportFeedbackResponseStatusFailed`         | FAILED                                            |
| `StartExportFeedbackResponseStatusCancelled`      | CANCELLED                                         |
| `StartExportFeedbackResponseStatusTerminated`     | TERMINATED                                        |
| `StartExportFeedbackResponseStatusContinuedAsNew` | CONTINUED_AS_NEW                                  |
| `StartExportFeedbackResponseStatusTimedOut`       | TIMED_OUT                                         |