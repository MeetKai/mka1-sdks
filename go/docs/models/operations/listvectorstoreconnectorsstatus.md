# ListVectorStoreConnectorsStatus

`syncing` while a run is in progress, `removing` while a delete or unsync is in progress, `error` when the last run failed, else `idle`.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.ListVectorStoreConnectorsStatusIdle

// Open enum: custom values can be created with a direct type cast
custom := operations.ListVectorStoreConnectorsStatus("custom_value")
```


## Values

| Name                                      | Value                                     |
| ----------------------------------------- | ----------------------------------------- |
| `ListVectorStoreConnectorsStatusIdle`     | idle                                      |
| `ListVectorStoreConnectorsStatusSyncing`  | syncing                                   |
| `ListVectorStoreConnectorsStatusRemoving` | removing                                  |
| `ListVectorStoreConnectorsStatusError`    | error                                     |