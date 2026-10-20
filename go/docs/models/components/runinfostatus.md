# RunInfoStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.RunInfoStatusRunning

// Open enum: custom values can be created with a direct type cast
custom := components.RunInfoStatus("custom_value")
```


## Values

| Name                     | Value                    |
| ------------------------ | ------------------------ |
| `RunInfoStatusRunning`   | RUNNING                  |
| `RunInfoStatusScheduled` | SCHEDULED                |
| `RunInfoStatusFinished`  | FINISHED                 |
| `RunInfoStatusFailed`    | FAILED                   |
| `RunInfoStatusKilled`    | KILLED                   |