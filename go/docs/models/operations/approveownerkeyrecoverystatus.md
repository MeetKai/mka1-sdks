# ApproveOwnerKeyRecoveryStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.ApproveOwnerKeyRecoveryStatusPending

// Open enum: custom values can be created with a direct type cast
custom := operations.ApproveOwnerKeyRecoveryStatus("custom_value")
```


## Values

| Name                                    | Value                                   |
| --------------------------------------- | --------------------------------------- |
| `ApproveOwnerKeyRecoveryStatusPending`  | pending                                 |
| `ApproveOwnerKeyRecoveryStatusApproved` | approved                                |
| `ApproveOwnerKeyRecoveryStatusRejected` | rejected                                |
| `ApproveOwnerKeyRecoveryStatusExpired`  | expired                                 |