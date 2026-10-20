# CodeInterpreterToolCallStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.CodeInterpreterToolCallStatusInProgress

// Open enum: custom values can be created with a direct type cast
custom := components.CodeInterpreterToolCallStatus("custom_value")
```


## Values

| Name                                        | Value                                       |
| ------------------------------------------- | ------------------------------------------- |
| `CodeInterpreterToolCallStatusInProgress`   | in_progress                                 |
| `CodeInterpreterToolCallStatusCompleted`    | completed                                   |
| `CodeInterpreterToolCallStatusIncomplete`   | incomplete                                  |
| `CodeInterpreterToolCallStatusInterpreting` | interpreting                                |
| `CodeInterpreterToolCallStatusFailed`       | failed                                      |