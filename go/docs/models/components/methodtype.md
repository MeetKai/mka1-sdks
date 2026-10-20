# MethodType

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.MethodTypeSupervised

// Open enum: custom values can be created with a direct type cast
custom := components.MethodType("custom_value")
```


## Values

| Name                      | Value                     |
| ------------------------- | ------------------------- |
| `MethodTypeSupervised`    | supervised                |
| `MethodTypeDpo`           | dpo                       |
| `MethodTypeReinforcement` | reinforcement             |