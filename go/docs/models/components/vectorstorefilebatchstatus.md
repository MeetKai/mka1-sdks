# VectorStoreFileBatchStatus

The status of the vector store files batch. 'in_progress' means files are being processed, 'completed' means all files have been processed, 'cancelled' means the batch was cancelled, 'failed' means the batch failed.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.VectorStoreFileBatchStatusInProgress

// Open enum: custom values can be created with a direct type cast
custom := components.VectorStoreFileBatchStatus("custom_value")
```


## Values

| Name                                   | Value                                  |
| -------------------------------------- | -------------------------------------- |
| `VectorStoreFileBatchStatusInProgress` | in_progress                            |
| `VectorStoreFileBatchStatusCompleted`  | completed                              |
| `VectorStoreFileBatchStatusCancelled`  | cancelled                              |
| `VectorStoreFileBatchStatusFailed`     | failed                                 |