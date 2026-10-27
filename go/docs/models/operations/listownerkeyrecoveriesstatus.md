# ListOwnerKeyRecoveriesStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.ListOwnerKeyRecoveriesStatusPending

// Open enum: custom values can be created with a direct type cast
custom := operations.ListOwnerKeyRecoveriesStatus("custom_value")
```


## Values

| Name                                   | Value                                  |
| -------------------------------------- | -------------------------------------- |
| `ListOwnerKeyRecoveriesStatusPending`  | pending                                |
| `ListOwnerKeyRecoveriesStatusApproved` | approved                               |
| `ListOwnerKeyRecoveriesStatusRejected` | rejected                               |
| `ListOwnerKeyRecoveriesStatusExpired`  | expired                                |