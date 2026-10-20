# VectorStoreStatus

The status of the vector store. 'expired' means the store has expired, 'in_progress' means files are still being processed, 'completed' indicates that the vector store is ready for use.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.VectorStoreStatusExpired

// Open enum: custom values can be created with a direct type cast
custom := components.VectorStoreStatus("custom_value")
```


## Values

| Name                          | Value                         |
| ----------------------------- | ----------------------------- |
| `VectorStoreStatusExpired`    | expired                       |
| `VectorStoreStatusInProgress` | in_progress                   |
| `VectorStoreStatusCompleted`  | completed                     |