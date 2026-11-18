# AgentsShellSessionScope

Shell workspace lifetime. conversation (default) keeps files within the same conversation or response chain. request starts a fresh workspace for this response and its default-scoped delegated agents. user uses the end user's own persistent computer: the same container for every run of that user (for connector runs, the chat user), whatever the conversation or API key, with /workspace kept for 90 days after its last use and the latest run's network policy and memory stores applied to it. Delegated agents inherit their parent's workspace without its conversation history; explicit child request or user scope, or container IDs, override inheritance.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.AgentsShellSessionScopeConversation

// Open enum: custom values can be created with a direct type cast
custom := components.AgentsShellSessionScope("custom_value")
```


## Values

| Name                                  | Value                                 |
| ------------------------------------- | ------------------------------------- |
| `AgentsShellSessionScopeConversation` | conversation                          |
| `AgentsShellSessionScopeRequest`      | request                               |
| `AgentsShellSessionScopeUser`         | user                                  |