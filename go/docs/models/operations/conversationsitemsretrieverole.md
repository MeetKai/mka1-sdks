# ConversationsItemsRetrieveRole

The role of the message sender (user, assistant, system, or developer).

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.ConversationsItemsRetrieveRoleUser

// Open enum: custom values can be created with a direct type cast
custom := operations.ConversationsItemsRetrieveRole("custom_value")
```


## Values

| Name                                      | Value                                     |
| ----------------------------------------- | ----------------------------------------- |
| `ConversationsItemsRetrieveRoleUser`      | user                                      |
| `ConversationsItemsRetrieveRoleAssistant` | assistant                                 |
| `ConversationsItemsRetrieveRoleSystem`    | system                                    |
| `ConversationsItemsRetrieveRoleDeveloper` | developer                                 |