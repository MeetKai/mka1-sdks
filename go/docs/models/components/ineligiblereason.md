# IneligibleReason

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.IneligibleReasonInactive

// Open enum: custom values can be created with a direct type cast
custom := components.IneligibleReason("custom_value")
```


## Values

| Name                               | Value                              |
| ---------------------------------- | ---------------------------------- |
| `IneligibleReasonInactive`         | inactive                           |
| `IneligibleReasonAPIFormatChanged` | api_format_changed                 |
| `IneligibleReasonNoResult`         | no_result                          |
| `IneligibleReasonFailedSamples`    | failed_samples                     |