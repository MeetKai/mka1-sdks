# ResponseStatus

The overall status of the response generation. 'completed' means successfully finished, 'failed' means error occurred, 'in_progress' means currently processing, 'cancelled' means user-cancelled, 'queued' means waiting to start, 'incomplete' means partial completion.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ResponseStatusCompleted

// Open enum: custom values can be created with a direct type cast
custom := components.ResponseStatus("custom_value")
```


## Values

| Name                       | Value                      |
| -------------------------- | -------------------------- |
| `ResponseStatusCompleted`  | completed                  |
| `ResponseStatusFailed`     | failed                     |
| `ResponseStatusInProgress` | in_progress                |
| `ResponseStatusCancelled`  | cancelled                  |
| `ResponseStatusQueued`     | queued                     |
| `ResponseStatusIncomplete` | incomplete                 |