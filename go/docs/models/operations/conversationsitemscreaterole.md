# ConversationsItemsCreateRole

The role of the message sender (user, assistant, system, or developer).

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.ConversationsItemsCreateRoleUser

// Open enum: custom values can be created with a direct type cast
custom := operations.ConversationsItemsCreateRole("custom_value")
```


## Values

| Name                                    | Value                                   |
| --------------------------------------- | --------------------------------------- |
| `ConversationsItemsCreateRoleUser`      | user                                    |
| `ConversationsItemsCreateRoleAssistant` | assistant                               |
| `ConversationsItemsCreateRoleSystem`    | system                                  |
| `ConversationsItemsCreateRoleDeveloper` | developer                               |