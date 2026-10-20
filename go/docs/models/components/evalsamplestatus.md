# EvalSampleStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.EvalSampleStatusQueued

// Open enum: custom values can be created with a direct type cast
custom := components.EvalSampleStatus("custom_value")
```


## Values

| Name                           | Value                          |
| ------------------------------ | ------------------------------ |
| `EvalSampleStatusQueued`       | queued                         |
| `EvalSampleStatusGenerating`   | generating                     |
| `EvalSampleStatusReadyToScore` | ready_to_score                 |
| `EvalSampleStatusScoring`      | scoring                        |
| `EvalSampleStatusRunning`      | running                        |
| `EvalSampleStatusCompleted`    | completed                      |
| `EvalSampleStatusFailed`       | failed                         |