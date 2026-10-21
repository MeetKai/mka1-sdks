# VectorStorePermissionRole

The role held on the store. `owner` is the store's creator and cannot be granted; `writer` includes `reader`.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.VectorStorePermissionRoleOwner

// Open enum: custom values can be created with a direct type cast
custom := components.VectorStorePermissionRole("custom_value")
```


## Values

| Name                              | Value                             |
| --------------------------------- | --------------------------------- |
| `VectorStorePermissionRoleOwner`  | owner                             |
| `VectorStorePermissionRoleWriter` | writer                            |
| `VectorStorePermissionRoleReader` | reader                            |