# FileSearchToolCallStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.FileSearchToolCallStatusInProgress

// Open enum: custom values can be created with a direct type cast
custom := components.FileSearchToolCallStatus("custom_value")
```


## Values

| Name                                 | Value                                |
| ------------------------------------ | ------------------------------------ |
| `FileSearchToolCallStatusInProgress` | in_progress                          |
| `FileSearchToolCallStatusSearching`  | searching                            |
| `FileSearchToolCallStatusCompleted`  | completed                            |
| `FileSearchToolCallStatusIncomplete` | incomplete                           |
| `FileSearchToolCallStatusFailed`     | failed                               |