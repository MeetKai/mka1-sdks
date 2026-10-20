# ShellCallOutputWithIDType

Whether the command exited normally or timed out.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ShellCallOutputWithIDTypeExit

// Open enum: custom values can be created with a direct type cast
custom := components.ShellCallOutputWithIDType("custom_value")
```


## Values

| Name                               | Value                              |
| ---------------------------------- | ---------------------------------- |
| `ShellCallOutputWithIDTypeExit`    | exit                               |
| `ShellCallOutputWithIDTypeTimeout` | timeout                            |