# AgentRunStatus

waiting means the run is held for one of the agent's max_concurrent_runs slots and has not been sent to the model; it can be cancelled. Terminal outcomes stay distinct: cancelled is caller-requested; incomplete means a limit or interruption stopped the run. gateway_response.incomplete_details records the reason, including max_tokens or max_tool_calls. Stored failed rows with one of these gateway outcomes are serialized with the gateway outcome, retaining any connector error and completion timestamp.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.AgentRunStatusWaiting

// Open enum: custom values can be created with a direct type cast
custom := components.AgentRunStatus("custom_value")
```


## Values

| Name                       | Value                      |
| -------------------------- | -------------------------- |
| `AgentRunStatusWaiting`    | waiting                    |
| `AgentRunStatusQueued`     | queued                     |
| `AgentRunStatusSubmitting` | submitting                 |
| `AgentRunStatusCompleted`  | completed                  |
| `AgentRunStatusFailed`     | failed                     |
| `AgentRunStatusCancelled`  | cancelled                  |
| `AgentRunStatusIncomplete` | incomplete                 |