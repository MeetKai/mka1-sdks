# VectorStoreFileStatus

The status of the vector store file. 'in_progress' means currently processing, 'completed' indicates the file is ready for use, 'cancelled' means processing was cancelled, 'failed' means an error occurred.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.VectorStoreFileStatusInProgress

// Open enum: custom values can be created with a direct type cast
custom := components.VectorStoreFileStatus("custom_value")
```


## Values

| Name                              | Value                             |
| --------------------------------- | --------------------------------- |
| `VectorStoreFileStatusInProgress` | in_progress                       |
| `VectorStoreFileStatusCompleted`  | completed                         |
| `VectorStoreFileStatusCancelled`  | cancelled                         |
| `VectorStoreFileStatusFailed`     | failed                            |