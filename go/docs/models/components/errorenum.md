# ErrorEnum

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ErrorEnumBadRequest

// Open enum: custom values can be created with a direct type cast
custom := components.ErrorEnum("custom_value")
```


## Values

| Name                              | Value                             |
| --------------------------------- | --------------------------------- |
| `ErrorEnumBadRequest`             | bad_request                       |
| `ErrorEnumAuthenticationRequired` | authentication_required           |
| `ErrorEnumForbidden`              | forbidden                         |
| `ErrorEnumNotFound`               | not_found                         |
| `ErrorEnumConflict`               | conflict                          |
| `ErrorEnumPreconditionFailed`     | precondition_failed               |
| `ErrorEnumMethodNotAllowed`       | method_not_allowed                |
| `ErrorEnumInternal`               | internal                          |