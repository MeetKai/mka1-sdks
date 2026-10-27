# RequestOwnerKeyRecoveryStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.RequestOwnerKeyRecoveryStatusPending

// Open enum: custom values can be created with a direct type cast
custom := operations.RequestOwnerKeyRecoveryStatus("custom_value")
```


## Values

| Name                                    | Value                                   |
| --------------------------------------- | --------------------------------------- |
| `RequestOwnerKeyRecoveryStatusPending`  | pending                                 |
| `RequestOwnerKeyRecoveryStatusApproved` | approved                                |
| `RequestOwnerKeyRecoveryStatusRejected` | rejected                                |
| `RequestOwnerKeyRecoveryStatusExpired`  | expired                                 |