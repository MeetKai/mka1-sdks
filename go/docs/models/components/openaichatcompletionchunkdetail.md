# OpenAIChatCompletionChunkDetail

The detail level of the image analysis. 'low' disables high-res mode, 'high' enables it, 'auto' lets the model decide.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.OpenAIChatCompletionChunkDetailAuto

// Open enum: custom values can be created with a direct type cast
custom := components.OpenAIChatCompletionChunkDetail("custom_value")
```


## Values

| Name                                  | Value                                 |
| ------------------------------------- | ------------------------------------- |
| `OpenAIChatCompletionChunkDetailAuto` | auto                                  |
| `OpenAIChatCompletionChunkDetailLow`  | low                                   |
| `OpenAIChatCompletionChunkDetailHigh` | high                                  |