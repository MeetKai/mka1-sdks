# Decision

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.DecisionCreate

// Open enum: custom values can be created with a direct type cast
custom := components.Decision("custom_value")
```


## Values

| Name                 | Value                |
| -------------------- | -------------------- |
| `DecisionCreate`     | create               |
| `DecisionManual`     | manual               |
| `DecisionAutoscaler` | autoscaler           |