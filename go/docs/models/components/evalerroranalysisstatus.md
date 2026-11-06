# EvalErrorAnalysisStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.EvalErrorAnalysisStatusQueued

// Open enum: custom values can be created with a direct type cast
custom := components.EvalErrorAnalysisStatus("custom_value")
```


## Values

| Name                             | Value                            |
| -------------------------------- | -------------------------------- |
| `EvalErrorAnalysisStatusQueued`  | queued                           |
| `EvalErrorAnalysisStatusRunning` | running                          |
| `EvalErrorAnalysisStatusDone`    | done                             |
| `EvalErrorAnalysisStatusFailed`  | failed                           |