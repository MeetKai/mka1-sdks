# GetOwnerKeyRecoveryStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.GetOwnerKeyRecoveryStatusPending

// Open enum: custom values can be created with a direct type cast
custom := operations.GetOwnerKeyRecoveryStatus("custom_value")
```


## Values

| Name                                | Value                               |
| ----------------------------------- | ----------------------------------- |
| `GetOwnerKeyRecoveryStatusPending`  | pending                             |
| `GetOwnerKeyRecoveryStatusApproved` | approved                            |
| `GetOwnerKeyRecoveryStatusRejected` | rejected                            |
| `GetOwnerKeyRecoveryStatusExpired`  | expired                             |