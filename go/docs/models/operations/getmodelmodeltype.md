# GetModelModelType

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.GetModelModelTypeLlm

// Open enum: custom values can be created with a direct type cast
custom := operations.GetModelModelType("custom_value")
```


## Values

| Name                            | Value                           |
| ------------------------------- | ------------------------------- |
| `GetModelModelTypeLlm`          | llm                             |
| `GetModelModelTypeEmbeddings`   | embeddings                      |
| `GetModelModelTypeImages`       | images                          |
| `GetModelModelTypeSpeechToText` | speech_to_text                  |
| `GetModelModelTypeTextToSpeech` | text_to_speech                  |