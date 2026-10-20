# EvalRunStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.EvalRunStatusQueued

// Open enum: custom values can be created with a direct type cast
custom := components.EvalRunStatus("custom_value")
```


## Values

| Name                      | Value                     |
| ------------------------- | ------------------------- |
| `EvalRunStatusQueued`     | queued                    |
| `EvalRunStatusInProgress` | in_progress               |
| `EvalRunStatusFinalizing` | finalizing                |
| `EvalRunStatusCompleted`  | completed                 |
| `EvalRunStatusFailed`     | failed                    |
| `EvalRunStatusCancelling` | cancelling                |
| `EvalRunStatusCancelled`  | cancelled                 |