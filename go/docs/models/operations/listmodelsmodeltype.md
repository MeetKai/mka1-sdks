# ListModelsModelType

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.ListModelsModelTypeLlm

// Open enum: custom values can be created with a direct type cast
custom := operations.ListModelsModelType("custom_value")
```


## Values

| Name                              | Value                             |
| --------------------------------- | --------------------------------- |
| `ListModelsModelTypeLlm`          | llm                               |
| `ListModelsModelTypeEmbeddings`   | embeddings                        |
| `ListModelsModelTypeImages`       | images                            |
| `ListModelsModelTypeSpeechToText` | speech_to_text                    |
| `ListModelsModelTypeTextToSpeech` | text_to_speech                    |