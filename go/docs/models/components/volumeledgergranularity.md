# VolumeLedgerGranularity

Immutable UTC bucket granularity of standalone-volume billing rows.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.VolumeLedgerGranularityHour

// Open enum: custom values can be created with a direct type cast
custom := components.VolumeLedgerGranularity("custom_value")
```


## Values

| Name                          | Value                         |
| ----------------------------- | ----------------------------- |
| `VolumeLedgerGranularityHour` | hour                          |