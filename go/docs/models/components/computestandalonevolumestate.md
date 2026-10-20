# ComputeStandaloneVolumeState

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ComputeStandaloneVolumeStateCreating

// Open enum: custom values can be created with a direct type cast
custom := components.ComputeStandaloneVolumeState("custom_value")
```


## Values

| Name                                   | Value                                  |
| -------------------------------------- | -------------------------------------- |
| `ComputeStandaloneVolumeStateCreating` | creating                               |
| `ComputeStandaloneVolumeStateReady`    | ready                                  |
| `ComputeStandaloneVolumeStateDeleting` | deleting                               |
| `ComputeStandaloneVolumeStateDeleted`  | deleted                                |
| `ComputeStandaloneVolumeStateFailed`   | failed                                 |