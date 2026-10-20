# InputMessageRole

The role of the message sender (user, assistant, system, or developer).

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.InputMessageRoleUser

// Open enum: custom values can be created with a direct type cast
custom := components.InputMessageRole("custom_value")
```


## Values

| Name                        | Value                       |
| --------------------------- | --------------------------- |
| `InputMessageRoleUser`      | user                        |
| `InputMessageRoleAssistant` | assistant                   |
| `InputMessageRoleSystem`    | system                      |
| `InputMessageRoleDeveloper` | developer                   |