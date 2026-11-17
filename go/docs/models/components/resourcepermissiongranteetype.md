# ResourcePermissionGranteeType

Who the permission applies to: one principal (`user`), or every member of the resource's team (`team`).

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ResourcePermissionGranteeTypeUser

// Open enum: custom values can be created with a direct type cast
custom := components.ResourcePermissionGranteeType("custom_value")
```


## Values

| Name                                | Value                               |
| ----------------------------------- | ----------------------------------- |
| `ResourcePermissionGranteeTypeUser` | user                                |
| `ResourcePermissionGranteeTypeTeam` | team                                |