# ListVectorStoreConnectorObjectsDataStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.ListVectorStoreConnectorObjectsDataStatusMirrored

// Open enum: custom values can be created with a direct type cast
custom := operations.ListVectorStoreConnectorObjectsDataStatus("custom_value")
```


## Values

| Name                                                | Value                                               |
| --------------------------------------------------- | --------------------------------------------------- |
| `ListVectorStoreConnectorObjectsDataStatusMirrored` | mirrored                                            |
| `ListVectorStoreConnectorObjectsDataStatusSkipped`  | skipped                                             |
| `ListVectorStoreConnectorObjectsDataStatusFailed`   | failed                                              |