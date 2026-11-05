# AuthType

oauth credentials come only from the OAuth connect flow.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.AuthTypeBearer

// Open enum: custom values can be created with a direct type cast
custom := components.AuthType("custom_value")
```


## Values

| Name                    | Value                   |
| ----------------------- | ----------------------- |
| `AuthTypeBearer`        | bearer                  |
| `AuthTypeAuthorization` | authorization           |
| `AuthTypeHeaders`       | headers                 |
| `AuthTypeNone`          | none                    |
| `AuthTypeOauth`         | oauth                   |