# AgentScheduleStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.AgentScheduleStatusActive

// Open enum: custom values can be created with a direct type cast
custom := components.AgentScheduleStatus("custom_value")
```


## Values

| Name                           | Value                          |
| ------------------------------ | ------------------------------ |
| `AgentScheduleStatusActive`    | active                         |
| `AgentScheduleStatusPaused`    | paused                         |
| `AgentScheduleStatusCompleted` | completed                      |
| `AgentScheduleStatusDeleted`   | deleted                        |