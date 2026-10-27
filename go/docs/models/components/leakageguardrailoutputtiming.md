# LeakageGuardrailOutputTiming

When this rule checks model output: final (default) checks the finished text once, after it has streamed; streaming holds streamed text in a window and releases only text this rule has cleared

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.LeakageGuardrailOutputTimingFinal

// Open enum: custom values can be created with a direct type cast
custom := components.LeakageGuardrailOutputTiming("custom_value")
```


## Values

| Name                                    | Value                                   |
| --------------------------------------- | --------------------------------------- |
| `LeakageGuardrailOutputTimingFinal`     | final                                   |
| `LeakageGuardrailOutputTimingStreaming` | streaming                               |