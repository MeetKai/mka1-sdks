# Operation

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.OperationEq

// Open enum: custom values can be created with a direct type cast
custom := components.Operation("custom_value")
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `OperationEq`    | eq               |
| `OperationNe`    | ne               |
| `OperationLike`  | like             |
| `OperationIlike` | ilike            |