# OpenAPIParameterIn

Where the parameter goes. Cookie parameters are not supported.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.OpenAPIParameterInPath

// Open enum: custom values can be created with a direct type cast
custom := components.OpenAPIParameterIn("custom_value")
```


## Values

| Name                       | Value                      |
| -------------------------- | -------------------------- |
| `OpenAPIParameterInPath`   | path                       |
| `OpenAPIParameterInQuery`  | query                      |
| `OpenAPIParameterInHeader` | header                     |