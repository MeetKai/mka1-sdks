# ComputeInstanceState

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ComputeInstanceStateRequested

// Open enum: custom values can be created with a direct type cast
custom := components.ComputeInstanceState("custom_value")
```


## Values

| Name                            | Value                           |
| ------------------------------- | ------------------------------- |
| `ComputeInstanceStateRequested` | requested                       |
| `ComputeInstanceStateStarting`  | starting                        |
| `ComputeInstanceStateRunning`   | running                         |
| `ComputeInstanceStateReady`     | ready                           |
| `ComputeInstanceStateBusy`      | busy                            |
| `ComputeInstanceStateStopping`  | stopping                        |
| `ComputeInstanceStateStopped`   | stopped                         |
| `ComputeInstanceStateSucceeded` | succeeded                       |
| `ComputeInstanceStateFailed`    | failed                          |
| `ComputeInstanceStateLost`      | lost                            |
| `ComputeInstanceStateUnknown`   | unknown                         |