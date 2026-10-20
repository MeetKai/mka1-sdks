# OutputMessageWithIDStatus

The processing status of this message (in_progress, completed, or incomplete).

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.OutputMessageWithIDStatusInProgress

// Open enum: custom values can be created with a direct type cast
custom := components.OutputMessageWithIDStatus("custom_value")
```


## Values

| Name                                  | Value                                 |
| ------------------------------------- | ------------------------------------- |
| `OutputMessageWithIDStatusInProgress` | in_progress                           |
| `OutputMessageWithIDStatusCompleted`  | completed                             |
| `OutputMessageWithIDStatusIncomplete` | incomplete                            |