# RejectOwnerKeyRecoveryConflictStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.RejectOwnerKeyRecoveryConflictStatusPending

// Open enum: custom values can be created with a direct type cast
custom := operations.RejectOwnerKeyRecoveryConflictStatus("custom_value")
```


## Values

| Name                                           | Value                                          |
| ---------------------------------------------- | ---------------------------------------------- |
| `RejectOwnerKeyRecoveryConflictStatusPending`  | pending                                        |
| `RejectOwnerKeyRecoveryConflictStatusApproved` | approved                                       |
| `RejectOwnerKeyRecoveryConflictStatusRejected` | rejected                                       |
| `RejectOwnerKeyRecoveryConflictStatusExpired`  | expired                                        |