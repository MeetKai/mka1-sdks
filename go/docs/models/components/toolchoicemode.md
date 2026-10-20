# ToolChoiceMode

Tool choice mode: Selects how the model decides tool usage. Use none, auto, or required.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ToolChoiceModeNone

// Open enum: custom values can be created with a direct type cast
custom := components.ToolChoiceMode("custom_value")
```


## Values

| Name                     | Value                    |
| ------------------------ | ------------------------ |
| `ToolChoiceModeNone`     | none                     |
| `ToolChoiceModeAuto`     | auto                     |
| `ToolChoiceModeRequired` | required                 |