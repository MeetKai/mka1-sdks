# OpenAIChatCompletionChoiceFinishReasonEnum

The reason why the model stopped generating tokens.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.OpenAIChatCompletionChoiceFinishReasonEnumStop

// Open enum: custom values can be created with a direct type cast
custom := components.OpenAIChatCompletionChoiceFinishReasonEnum("custom_value")
```


## Values

| Name                                                      | Value                                                     |
| --------------------------------------------------------- | --------------------------------------------------------- |
| `OpenAIChatCompletionChoiceFinishReasonEnumStop`          | stop                                                      |
| `OpenAIChatCompletionChoiceFinishReasonEnumLength`        | length                                                    |
| `OpenAIChatCompletionChoiceFinishReasonEnumToolCalls`     | tool_calls                                                |
| `OpenAIChatCompletionChoiceFinishReasonEnumContentFilter` | content_filter                                            |