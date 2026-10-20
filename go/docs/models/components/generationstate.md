# GenerationState

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.GenerationStatePending

// Open enum: custom values can be created with a direct type cast
custom := components.GenerationState("custom_value")
```


## Values

| Name                        | Value                       |
| --------------------------- | --------------------------- |
| `GenerationStatePending`    | pending                     |
| `GenerationStateRunning`    | running                     |
| `GenerationStatePublishing` | publishing                  |
| `GenerationStateSucceeded`  | succeeded                   |
| `GenerationStateFailed`     | failed                      |
| `GenerationStateCancelling` | cancelling                  |
| `GenerationStateCancelled`  | cancelled                   |