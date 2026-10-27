# ClusterDefaultRuleSummaryOutputTiming

When this guardrail checks model output: once on the finished text (final, the default) or while it streams

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ClusterDefaultRuleSummaryOutputTimingFinal

// Open enum: custom values can be created with a direct type cast
custom := components.ClusterDefaultRuleSummaryOutputTiming("custom_value")
```


## Values

| Name                                             | Value                                            |
| ------------------------------------------------ | ------------------------------------------------ |
| `ClusterDefaultRuleSummaryOutputTimingFinal`     | final                                            |
| `ClusterDefaultRuleSummaryOutputTimingStreaming` | streaming                                        |