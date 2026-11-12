# AgentRunPendingApprovalKind

mcp_approval_request for an MCP tool call, tool_approval_request for a built-in tool call held by the organization's tool policy.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.AgentRunPendingApprovalKindMcpApprovalRequest

// Open enum: custom values can be created with a direct type cast
custom := components.AgentRunPendingApprovalKind("custom_value")
```


## Values

| Name                                             | Value                                            |
| ------------------------------------------------ | ------------------------------------------------ |
| `AgentRunPendingApprovalKindMcpApprovalRequest`  | mcp_approval_request                             |
| `AgentRunPendingApprovalKindToolApprovalRequest` | tool_approval_request                            |