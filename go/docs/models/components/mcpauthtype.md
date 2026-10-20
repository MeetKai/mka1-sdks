# MCPAuthType

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.MCPAuthTypeBearer

// Open enum: custom values can be created with a direct type cast
custom := components.MCPAuthType("custom_value")
```


## Values

| Name                       | Value                      |
| -------------------------- | -------------------------- |
| `MCPAuthTypeBearer`        | bearer                     |
| `MCPAuthTypeAuthorization` | authorization              |
| `MCPAuthTypeHeaders`       | headers                    |
| `MCPAuthTypeNone`          | none                       |