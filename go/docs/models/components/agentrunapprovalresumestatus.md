# AgentRunApprovalResumeStatus

waiting while a held call of the run is undecided, with the count in pending; resumed once the run was continued, with the new run in continuation_run.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.AgentRunApprovalResumeStatusWaiting

// Open enum: custom values can be created with a direct type cast
custom := components.AgentRunApprovalResumeStatus("custom_value")
```


## Values

| Name                                  | Value                                 |
| ------------------------------------- | ------------------------------------- |
| `AgentRunApprovalResumeStatusWaiting` | waiting                               |
| `AgentRunApprovalResumeStatusResumed` | resumed                               |