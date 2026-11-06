# StatusComponentStatus

Least to most severe: operational, degraded_performance, partial_outage, major_outage.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.StatusComponentStatusOperational

// Open enum: custom values can be created with a direct type cast
custom := components.StatusComponentStatus("custom_value")
```


## Values

| Name                                       | Value                                      |
| ------------------------------------------ | ------------------------------------------ |
| `StatusComponentStatusOperational`         | operational                                |
| `StatusComponentStatusDegradedPerformance` | degraded_performance                       |
| `StatusComponentStatusPartialOutage`       | partial_outage                             |
| `StatusComponentStatusMajorOutage`         | major_outage                               |