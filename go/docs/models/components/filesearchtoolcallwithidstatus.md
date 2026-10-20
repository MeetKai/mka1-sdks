# FileSearchToolCallWithIDStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.FileSearchToolCallWithIDStatusInProgress

// Open enum: custom values can be created with a direct type cast
custom := components.FileSearchToolCallWithIDStatus("custom_value")
```


## Values

| Name                                       | Value                                      |
| ------------------------------------------ | ------------------------------------------ |
| `FileSearchToolCallWithIDStatusInProgress` | in_progress                                |
| `FileSearchToolCallWithIDStatusSearching`  | searching                                  |
| `FileSearchToolCallWithIDStatusCompleted`  | completed                                  |
| `FileSearchToolCallWithIDStatusIncomplete` | incomplete                                 |
| `FileSearchToolCallWithIDStatusFailed`     | failed                                     |