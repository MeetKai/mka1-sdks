# ToolApprovalStatus

pending until an approver decides, or, for an approval without approvers, until the caller's continuation answers it. expired when the deadline passed without a decision.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ToolApprovalStatusPending

// Open enum: custom values can be created with a direct type cast
custom := components.ToolApprovalStatus("custom_value")
```


## Values

| Name                         | Value                        |
| ---------------------------- | ---------------------------- |
| `ToolApprovalStatusPending`  | pending                      |
| `ToolApprovalStatusApproved` | approved                     |
| `ToolApprovalStatusDenied`   | denied                       |
| `ToolApprovalStatusExpired`  | expired                      |