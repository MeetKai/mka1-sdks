# GetExportStatusResponseStatus

Current status of the export job

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.GetExportStatusResponseStatusUnknown

// Open enum: custom values can be created with a direct type cast
custom := components.GetExportStatusResponseStatus("custom_value")
```


## Values

| Name                                          | Value                                         |
| --------------------------------------------- | --------------------------------------------- |
| `GetExportStatusResponseStatusUnknown`        | UNKNOWN                                       |
| `GetExportStatusResponseStatusNotFound`       | NOT_FOUND                                     |
| `GetExportStatusResponseStatusRunning`        | RUNNING                                       |
| `GetExportStatusResponseStatusCompleted`      | COMPLETED                                     |
| `GetExportStatusResponseStatusFailed`         | FAILED                                        |
| `GetExportStatusResponseStatusCancelled`      | CANCELLED                                     |
| `GetExportStatusResponseStatusTerminated`     | TERMINATED                                    |
| `GetExportStatusResponseStatusContinuedAsNew` | CONTINUED_AS_NEW                              |
| `GetExportStatusResponseStatusTimedOut`       | TIMED_OUT                                     |