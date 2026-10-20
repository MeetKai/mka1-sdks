# SessionStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.SessionStatusQueued

// Open enum: custom values can be created with a direct type cast
custom := components.SessionStatus("custom_value")
```


## Values

| Name                        | Value                       |
| --------------------------- | --------------------------- |
| `SessionStatusQueued`       | queued                      |
| `SessionStatusPending`      | pending                     |
| `SessionStatusProvisioning` | provisioning                |
| `SessionStatusRunning`      | running                     |
| `SessionStatusIdle`         | idle                        |
| `SessionStatusStopping`     | stopping                    |
| `SessionStatusStopped`      | stopped                     |
| `SessionStatusFailed`       | failed                      |
| `SessionStatusTerminated`   | terminated                  |