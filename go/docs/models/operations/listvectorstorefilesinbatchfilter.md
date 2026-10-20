# ListVectorStoreFilesInBatchFilter

Filter by file status. One of in_progress, completed, failed, cancelled.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.ListVectorStoreFilesInBatchFilterInProgress
```


## Values

| Name                                          | Value                                         |
| --------------------------------------------- | --------------------------------------------- |
| `ListVectorStoreFilesInBatchFilterInProgress` | in_progress                                   |
| `ListVectorStoreFilesInBatchFilterCompleted`  | completed                                     |
| `ListVectorStoreFilesInBatchFilterFailed`     | failed                                        |
| `ListVectorStoreFilesInBatchFilterCancelled`  | cancelled                                     |