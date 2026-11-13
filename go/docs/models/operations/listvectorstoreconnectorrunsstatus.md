# ListVectorStoreConnectorRunsStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.ListVectorStoreConnectorRunsStatusRunning

// Open enum: custom values can be created with a direct type cast
custom := operations.ListVectorStoreConnectorRunsStatus("custom_value")
```


## Values

| Name                                          | Value                                         |
| --------------------------------------------- | --------------------------------------------- |
| `ListVectorStoreConnectorRunsStatusRunning`   | running                                       |
| `ListVectorStoreConnectorRunsStatusCompleted` | completed                                     |
| `ListVectorStoreConnectorRunsStatusFailed`    | failed                                        |