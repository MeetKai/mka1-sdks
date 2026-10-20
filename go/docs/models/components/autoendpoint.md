# AutoEndpoint

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.AutoEndpointResponses

// Open enum: custom values can be created with a direct type cast
custom := components.AutoEndpoint("custom_value")
```


## Values

| Name                         | Value                        |
| ---------------------------- | ---------------------------- |
| `AutoEndpointResponses`      | responses                    |
| `AutoEndpointCompletions`    | completions                  |
| `AutoEndpointEmbeddings`     | embeddings                   |
| `AutoEndpointImages`         | images                       |
| `AutoEndpointTranscriptions` | transcriptions               |
| `AutoEndpointTts`            | tts                          |