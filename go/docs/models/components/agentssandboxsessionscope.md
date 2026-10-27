# AgentsSandboxSessionScope

Workspace lifetime. conversation (default) keeps files within the same conversation or response chain. Delegated agents inherit their parent's workspace without its conversation history. request starts a fresh workspace for this response and its default-scoped delegated agents. Explicit child request scope or container IDs override inheritance. Independent top-level responses start fresh.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.AgentsSandboxSessionScopeConversation

// Open enum: custom values can be created with a direct type cast
custom := components.AgentsSandboxSessionScope("custom_value")
```


## Values

| Name                                    | Value                                   |
| --------------------------------------- | --------------------------------------- |
| `AgentsSandboxSessionScopeConversation` | conversation                            |
| `AgentsSandboxSessionScopeRequest`      | request                                 |