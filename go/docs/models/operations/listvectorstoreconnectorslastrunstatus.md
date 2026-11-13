# ListVectorStoreConnectorsLastRunStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.ListVectorStoreConnectorsLastRunStatusRunning

// Open enum: custom values can be created with a direct type cast
custom := operations.ListVectorStoreConnectorsLastRunStatus("custom_value")
```


## Values

| Name                                              | Value                                             |
| ------------------------------------------------- | ------------------------------------------------- |
| `ListVectorStoreConnectorsLastRunStatusRunning`   | running                                           |
| `ListVectorStoreConnectorsLastRunStatusCompleted` | completed                                         |
| `ListVectorStoreConnectorsLastRunStatusFailed`    | failed                                            |