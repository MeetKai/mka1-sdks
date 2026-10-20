# OutputMessageStatus

The processing status of this message (in_progress, completed, or incomplete).

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.OutputMessageStatusInProgress

// Open enum: custom values can be created with a direct type cast
custom := components.OutputMessageStatus("custom_value")
```


## Values

| Name                            | Value                           |
| ------------------------------- | ------------------------------- |
| `OutputMessageStatusInProgress` | in_progress                     |
| `OutputMessageStatusCompleted`  | completed                       |
| `OutputMessageStatusIncomplete` | incomplete                      |