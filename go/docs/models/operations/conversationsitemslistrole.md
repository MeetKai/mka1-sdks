# ConversationsItemsListRole

The role of the message sender (user, assistant, system, or developer).

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.ConversationsItemsListRoleUser

// Open enum: custom values can be created with a direct type cast
custom := operations.ConversationsItemsListRole("custom_value")
```


## Values

| Name                                  | Value                                 |
| ------------------------------------- | ------------------------------------- |
| `ConversationsItemsListRoleUser`      | user                                  |
| `ConversationsItemsListRoleAssistant` | assistant                             |
| `ConversationsItemsListRoleSystem`    | system                                |
| `ConversationsItemsListRoleDeveloper` | developer                             |