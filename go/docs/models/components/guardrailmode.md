# GuardrailMode

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.GuardrailModeBanWords

// Open enum: custom values can be created with a direct type cast
custom := components.GuardrailMode("custom_value")
```


## Values

| Name                           | Value                          |
| ------------------------------ | ------------------------------ |
| `GuardrailModeBanWords`        | ban_words                      |
| `GuardrailModePromptInjection` | prompt_injection               |
| `GuardrailModeLeakage`         | leakage                        |
| `GuardrailModeClassifier`      | classifier                     |