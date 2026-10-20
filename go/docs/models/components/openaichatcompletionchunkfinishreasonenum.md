# OpenAIChatCompletionChunkFinishReasonEnum

The reason why the model stopped generating tokens.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.OpenAIChatCompletionChunkFinishReasonEnumStop

// Open enum: custom values can be created with a direct type cast
custom := components.OpenAIChatCompletionChunkFinishReasonEnum("custom_value")
```


## Values

| Name                                                     | Value                                                    |
| -------------------------------------------------------- | -------------------------------------------------------- |
| `OpenAIChatCompletionChunkFinishReasonEnumStop`          | stop                                                     |
| `OpenAIChatCompletionChunkFinishReasonEnumLength`        | length                                                   |
| `OpenAIChatCompletionChunkFinishReasonEnumToolCalls`     | tool_calls                                               |
| `OpenAIChatCompletionChunkFinishReasonEnumContentFilter` | content_filter                                           |