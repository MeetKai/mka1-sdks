# InviteClusterOrgMembersStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.InviteClusterOrgMembersStatusSent

// Open enum: custom values can be created with a direct type cast
custom := operations.InviteClusterOrgMembersStatus("custom_value")
```


## Values

| Name                                          | Value                                         |
| --------------------------------------------- | --------------------------------------------- |
| `InviteClusterOrgMembersStatusSent`           | sent                                          |
| `InviteClusterOrgMembersStatusEmailFailed`    | email_failed                                  |
| `InviteClusterOrgMembersStatusAlreadyInvited` | already_invited                               |
| `InviteClusterOrgMembersStatusAlreadyMember`  | already_member                                |
| `InviteClusterOrgMembersStatusError`          | error                                         |