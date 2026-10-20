# OpenAIChatCompletionChoiceDetail

The detail level of the image analysis. 'low' disables high-res mode, 'high' enables it, 'auto' lets the model decide.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.OpenAIChatCompletionChoiceDetailAuto

// Open enum: custom values can be created with a direct type cast
custom := components.OpenAIChatCompletionChoiceDetail("custom_value")
```


## Values

| Name                                   | Value                                  |
| -------------------------------------- | -------------------------------------- |
| `OpenAIChatCompletionChoiceDetailAuto` | auto                                   |
| `OpenAIChatCompletionChoiceDetailLow`  | low                                    |
| `OpenAIChatCompletionChoiceDetailHigh` | high                                   |