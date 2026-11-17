# ResourcePermissionRole

The role held on the resource. `owner` is the resource's creator and cannot be granted; `writer` includes `reader`.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ResourcePermissionRoleOwner

// Open enum: custom values can be created with a direct type cast
custom := components.ResourcePermissionRole("custom_value")
```


## Values

| Name                           | Value                          |
| ------------------------------ | ------------------------------ |
| `ResourcePermissionRoleOwner`  | owner                          |
| `ResourcePermissionRoleWriter` | writer                         |
| `ResourcePermissionRoleReader` | reader                         |