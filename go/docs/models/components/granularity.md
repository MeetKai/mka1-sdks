# Granularity

Required alignment and allocation granularity of the requested window.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.GranularityMinute

// Open enum: custom values can be created with a direct type cast
custom := components.Granularity("custom_value")
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `GranularityMinute` | minute              |