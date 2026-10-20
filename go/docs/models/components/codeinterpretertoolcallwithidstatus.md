# CodeInterpreterToolCallWithIDStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.CodeInterpreterToolCallWithIDStatusInProgress

// Open enum: custom values can be created with a direct type cast
custom := components.CodeInterpreterToolCallWithIDStatus("custom_value")
```


## Values

| Name                                              | Value                                             |
| ------------------------------------------------- | ------------------------------------------------- |
| `CodeInterpreterToolCallWithIDStatusInProgress`   | in_progress                                       |
| `CodeInterpreterToolCallWithIDStatusCompleted`    | completed                                         |
| `CodeInterpreterToolCallWithIDStatusIncomplete`   | incomplete                                        |
| `CodeInterpreterToolCallWithIDStatusInterpreting` | interpreting                                      |
| `CodeInterpreterToolCallWithIDStatusFailed`       | failed                                            |