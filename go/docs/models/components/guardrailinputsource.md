# GuardrailInputSource

A source of model input: user (user messages and text sent to a sleeping response), system (system and developer messages, instructions and compaction summaries), assistant (earlier assistant messages), tool (function, custom tool, MCP, shell and code interpreter results), retrieval (file search, web search, web page, uploaded file and history search results), image (text read from images in messages) or audio (transcripts of audio in messages)

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.GuardrailInputSourceUser

// Open enum: custom values can be created with a direct type cast
custom := components.GuardrailInputSource("custom_value")
```


## Values

| Name                            | Value                           |
| ------------------------------- | ------------------------------- |
| `GuardrailInputSourceUser`      | user                            |
| `GuardrailInputSourceSystem`    | system                          |
| `GuardrailInputSourceAssistant` | assistant                       |
| `GuardrailInputSourceTool`      | tool                            |
| `GuardrailInputSourceRetrieval` | retrieval                       |
| `GuardrailInputSourceImage`     | image                           |
| `GuardrailInputSourceAudio`     | audio                           |