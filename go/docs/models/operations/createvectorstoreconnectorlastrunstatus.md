# CreateVectorStoreConnectorLastRunStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.CreateVectorStoreConnectorLastRunStatusRunning

// Open enum: custom values can be created with a direct type cast
custom := operations.CreateVectorStoreConnectorLastRunStatus("custom_value")
```


## Values

| Name                                               | Value                                              |
| -------------------------------------------------- | -------------------------------------------------- |
| `CreateVectorStoreConnectorLastRunStatusRunning`   | running                                            |
| `CreateVectorStoreConnectorLastRunStatusCompleted` | completed                                          |
| `CreateVectorStoreConnectorLastRunStatusFailed`    | failed                                             |