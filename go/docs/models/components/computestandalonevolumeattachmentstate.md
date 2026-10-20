# ComputeStandaloneVolumeAttachmentState

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ComputeStandaloneVolumeAttachmentStateReserved

// Open enum: custom values can be created with a direct type cast
custom := components.ComputeStandaloneVolumeAttachmentState("custom_value")
```


## Values

| Name                                              | Value                                             |
| ------------------------------------------------- | ------------------------------------------------- |
| `ComputeStandaloneVolumeAttachmentStateReserved`  | reserved                                          |
| `ComputeStandaloneVolumeAttachmentStateAttaching` | attaching                                         |
| `ComputeStandaloneVolumeAttachmentStateAttached`  | attached                                          |
| `ComputeStandaloneVolumeAttachmentStateReleasing` | releasing                                         |
| `ComputeStandaloneVolumeAttachmentStateReleased`  | released                                          |
| `ComputeStandaloneVolumeAttachmentStateFailed`    | failed                                            |