# StatusIncidentSource

`monitor` incidents were opened automatically from failing health checks.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.StatusIncidentSourceOperator

// Open enum: custom values can be created with a direct type cast
custom := components.StatusIncidentSource("custom_value")
```


## Values

| Name                           | Value                          |
| ------------------------------ | ------------------------------ |
| `StatusIncidentSourceOperator` | operator                       |
| `StatusIncidentSourceMonitor`  | monitor                        |