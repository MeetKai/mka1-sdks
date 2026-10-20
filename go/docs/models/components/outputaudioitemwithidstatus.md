# OutputAudioItemWithIDStatus

The processing status of this audio item.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.OutputAudioItemWithIDStatusInProgress

// Open enum: custom values can be created with a direct type cast
custom := components.OutputAudioItemWithIDStatus("custom_value")
```


## Values

| Name                                    | Value                                   |
| --------------------------------------- | --------------------------------------- |
| `OutputAudioItemWithIDStatusInProgress` | in_progress                             |
| `OutputAudioItemWithIDStatusCompleted`  | completed                               |
| `OutputAudioItemWithIDStatusIncomplete` | incomplete                              |