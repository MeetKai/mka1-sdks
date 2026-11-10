# State

`ok`: serving a ranked winner. `waiting_for_results`: no complete result to rank yet, so the last winner or the default holds. `metric_missing`: the suite's active version no longer declares the metric or task. `suite_missing`: the suite was deleted. The last two hold the last winner until the alias is edited.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.StateOk

// Open enum: custom values can be created with a direct type cast
custom := components.State("custom_value")
```


## Values

| Name                     | Value                    |
| ------------------------ | ------------------------ |
| `StateOk`                | ok                       |
| `StateWaitingForResults` | waiting_for_results      |
| `StateMetricMissing`     | metric_missing           |
| `StateSuiteMissing`      | suite_missing            |