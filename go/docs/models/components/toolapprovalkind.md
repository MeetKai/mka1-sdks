# ToolApprovalKind

The type of the approval request item: mcp_approval_request for an MCP call, tool_approval_request for a built-in tool.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ToolApprovalKindMcpApprovalRequest

// Open enum: custom values can be created with a direct type cast
custom := components.ToolApprovalKind("custom_value")
```


## Values

| Name                                  | Value                                 |
| ------------------------------------- | ------------------------------------- |
| `ToolApprovalKindMcpApprovalRequest`  | mcp_approval_request                  |
| `ToolApprovalKindToolApprovalRequest` | tool_approval_request                 |