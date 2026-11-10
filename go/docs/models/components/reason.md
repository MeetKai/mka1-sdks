# Reason

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ReasonCreated

// Open enum: custom values can be created with a direct type cast
custom := components.Reason("custom_value")
```


## Values

| Name                   | Value                  |
| ---------------------- | ---------------------- |
| `ReasonCreated`        | created                |
| `ReasonRunCompleted`   | run_completed          |
| `ReasonResultsChanged` | results_changed        |
| `ReasonConfigUpdated`  | config_updated         |
| `ReasonPinned`         | pinned                 |
| `ReasonUnpinned`       | unpinned               |
| `ReasonManual`         | manual                 |
| `ReasonReconcile`      | reconcile              |
| `ReasonDeleted`        | deleted                |