# ComputeResourceState

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ComputeResourceStateRequested

// Open enum: custom values can be created with a direct type cast
custom := components.ComputeResourceState("custom_value")
```


## Values

| Name                               | Value                              |
| ---------------------------------- | ---------------------------------- |
| `ComputeResourceStateRequested`    | requested                          |
| `ComputeResourceStateAllocating`   | allocating                         |
| `ComputeResourceStateProvisioning` | provisioning                       |
| `ComputeResourceStateRunning`      | running                            |
| `ComputeResourceStateReady`        | ready                              |
| `ComputeResourceStateFinalizing`   | finalizing                         |
| `ComputeResourceStateTerminating`  | terminating                        |
| `ComputeResourceStateSucceeded`    | succeeded                          |
| `ComputeResourceStateFailed`       | failed                             |
| `ComputeResourceStateTerminated`   | terminated                         |