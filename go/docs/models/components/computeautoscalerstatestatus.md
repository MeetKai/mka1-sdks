# ComputeAutoscalerStateStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ComputeAutoscalerStateStatusDisabled

// Open enum: custom values can be created with a direct type cast
custom := components.ComputeAutoscalerStateStatus("custom_value")
```


## Values

| Name                                      | Value                                     |
| ----------------------------------------- | ----------------------------------------- |
| `ComputeAutoscalerStateStatusDisabled`    | disabled                                  |
| `ComputeAutoscalerStateStatusActive`      | active                                    |
| `ComputeAutoscalerStateStatusCoolingDown` | cooling_down                              |
| `ComputeAutoscalerStateStatusBlocked`     | blocked                                   |
| `ComputeAutoscalerStateStatusUnknown`     | unknown                                   |