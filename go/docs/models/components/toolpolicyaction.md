# ToolPolicyAction

deny refuses requests that configure the tool (an MCP rule naming tool_names instead removes those tools). require_approval holds every call for an approval decision before it runs, overriding the request's require_approval.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ToolPolicyActionDeny

// Open enum: custom values can be created with a direct type cast
custom := components.ToolPolicyAction("custom_value")
```


## Values

| Name                              | Value                             |
| --------------------------------- | --------------------------------- |
| `ToolPolicyActionDeny`            | deny                              |
| `ToolPolicyActionRequireApproval` | require_approval                  |