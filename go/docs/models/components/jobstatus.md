# JobStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.JobStatusValidatingFiles

// Open enum: custom values can be created with a direct type cast
custom := components.JobStatus("custom_value")
```


## Values

| Name                       | Value                      |
| -------------------------- | -------------------------- |
| `JobStatusValidatingFiles` | validating_files           |
| `JobStatusQueued`          | queued                     |
| `JobStatusRunning`         | running                    |
| `JobStatusSucceeded`       | succeeded                  |
| `JobStatusFailed`          | failed                     |
| `JobStatusCancelled`       | cancelled                  |