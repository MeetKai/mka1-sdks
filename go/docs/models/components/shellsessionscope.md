# ShellSessionScope

Workspace lifetime. conversation (default) reuses the conversation or previous_response_id chain workspace; independent top-level responses start fresh. Delegated agents inherit their parent's workspace by default without inheriting its conversation history. request starts a fresh workspace for this response and its default-scoped delegated agents. user uses the caller's own persistent computer: the same container for every response of that user (org, team, user and external user), whatever the conversation or API key, with /workspace kept for 90 days after its last use. Its network_policy and memory_stores follow the latest response that uses it. Explicit child request or user scope, or container IDs, override inheritance.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ShellSessionScopeConversation

// Open enum: custom values can be created with a direct type cast
custom := components.ShellSessionScope("custom_value")
```


## Values

| Name                            | Value                           |
| ------------------------------- | ------------------------------- |
| `ShellSessionScopeConversation` | conversation                    |
| `ShellSessionScopeRequest`      | request                         |
| `ShellSessionScopeUser`         | user                            |