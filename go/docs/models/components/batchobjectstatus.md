# BatchObjectStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.BatchObjectStatusValidating

// Open enum: custom values can be created with a direct type cast
custom := components.BatchObjectStatus("custom_value")
```


## Values

| Name                          | Value                         |
| ----------------------------- | ----------------------------- |
| `BatchObjectStatusValidating` | validating                    |
| `BatchObjectStatusFailed`     | failed                        |
| `BatchObjectStatusInProgress` | in_progress                   |
| `BatchObjectStatusFinalizing` | finalizing                    |
| `BatchObjectStatusCompleted`  | completed                     |
| `BatchObjectStatusExpired`    | expired                       |
| `BatchObjectStatusCancelling` | cancelling                    |
| `BatchObjectStatusCancelled`  | cancelled                     |