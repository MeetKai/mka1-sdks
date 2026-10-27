# RejectOwnerKeyRecoveryStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.RejectOwnerKeyRecoveryStatusPending

// Open enum: custom values can be created with a direct type cast
custom := operations.RejectOwnerKeyRecoveryStatus("custom_value")
```


## Values

| Name                                   | Value                                  |
| -------------------------------------- | -------------------------------------- |
| `RejectOwnerKeyRecoveryStatusPending`  | pending                                |
| `RejectOwnerKeyRecoveryStatusApproved` | approved                               |
| `RejectOwnerKeyRecoveryStatusRejected` | rejected                               |
| `RejectOwnerKeyRecoveryStatusExpired`  | expired                                |