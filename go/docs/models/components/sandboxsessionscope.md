# SandboxSessionScope

Workspace lifetime. conversation (default) reuses the conversation or previous_response_id chain workspace; independent top-level responses start fresh. Delegated agents inherit their parent's workspace by default without inheriting its conversation history. request starts a fresh workspace for this response and its default-scoped delegated agents. Explicit child request scope or container IDs override inheritance.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.SandboxSessionScopeConversation

// Open enum: custom values can be created with a direct type cast
custom := components.SandboxSessionScope("custom_value")
```


## Values

| Name                              | Value                             |
| --------------------------------- | --------------------------------- |
| `SandboxSessionScopeConversation` | conversation                      |
| `SandboxSessionScopeRequest`      | request                           |