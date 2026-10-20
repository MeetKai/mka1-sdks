# OutputMessagePhase

Labels an assistant message as intermediate commentary or the final answer.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.OutputMessagePhaseCommentary

// Open enum: custom values can be created with a direct type cast
custom := components.OutputMessagePhase("custom_value")
```


## Values

| Name                            | Value                           |
| ------------------------------- | ------------------------------- |
| `OutputMessagePhaseCommentary`  | commentary                      |
| `OutputMessagePhaseFinalAnswer` | final_answer                    |