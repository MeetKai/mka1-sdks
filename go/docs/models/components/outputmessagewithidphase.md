# OutputMessageWithIDPhase

Labels an assistant message as intermediate commentary or the final answer.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.OutputMessageWithIDPhaseCommentary

// Open enum: custom values can be created with a direct type cast
custom := components.OutputMessageWithIDPhase("custom_value")
```


## Values

| Name                                  | Value                                 |
| ------------------------------------- | ------------------------------------- |
| `OutputMessageWithIDPhaseCommentary`  | commentary                            |
| `OutputMessageWithIDPhaseFinalAnswer` | final_answer                          |