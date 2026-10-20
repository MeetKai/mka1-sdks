# ComputeVolumeStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ComputeVolumeStatusProvisioning

// Open enum: custom values can be created with a direct type cast
custom := components.ComputeVolumeStatus("custom_value")
```


## Values

| Name                              | Value                             |
| --------------------------------- | --------------------------------- |
| `ComputeVolumeStatusProvisioning` | provisioning                      |
| `ComputeVolumeStatusLoading`      | loading                           |
| `ComputeVolumeStatusReady`        | ready                             |
| `ComputeVolumeStatusDeleting`     | deleting                          |
| `ComputeVolumeStatusDeleted`      | deleted                           |
| `ComputeVolumeStatusFailed`       | failed                            |