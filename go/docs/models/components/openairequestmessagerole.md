# OpenAIRequestMessageRole

The role of the message author. Determines how the message is interpreted by the model.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.OpenAIRequestMessageRoleSystem
```


## Values

| Name                                | Value                               |
| ----------------------------------- | ----------------------------------- |
| `OpenAIRequestMessageRoleSystem`    | system                              |
| `OpenAIRequestMessageRoleUser`      | user                                |
| `OpenAIRequestMessageRoleAssistant` | assistant                           |
| `OpenAIRequestMessageRoleTool`      | tool                                |
| `OpenAIRequestMessageRoleDeveloper` | developer                           |