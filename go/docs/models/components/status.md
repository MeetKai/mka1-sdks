# Status

The processing status of an individual item. 'in_progress' means currently processing, 'completed' means finished successfully, 'incomplete' means processing stopped before completion.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.StatusInProgress

// Open enum: custom values can be created with a direct type cast
custom := components.Status("custom_value")
```


## Values

| Name               | Value              |
| ------------------ | ------------------ |
| `StatusInProgress` | in_progress        |
| `StatusCompleted`  | completed          |
| `StatusIncomplete` | incomplete         |