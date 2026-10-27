# Kind

A model invocation or a tool call

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.KindModel

// Open enum: custom values can be created with a direct type cast
custom := operations.Kind("custom_value")
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `KindModel` | model       |
| `KindTool`  | tool        |