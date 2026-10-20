# VolumeAllocation

Finalized hourly volume totals are allocated uniformly over their immutable billable interval.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.VolumeAllocationUniformProration

// Open enum: custom values can be created with a direct type cast
custom := components.VolumeAllocation("custom_value")
```


## Values

| Name                               | Value                              |
| ---------------------------------- | ---------------------------------- |
| `VolumeAllocationUniformProration` | uniform_proration                  |