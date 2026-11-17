# ResourcePermissionSource

Where the role comes from: the resource's owner, a permission held by this principal, the resource's `team` permission, or nothing — the principal reaches the resource only as an org admin of its team, if at all.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ResourcePermissionSourceOwner

// Open enum: custom values can be created with a direct type cast
custom := components.ResourcePermissionSource("custom_value")
```


## Values

| Name                            | Value                           |
| ------------------------------- | ------------------------------- |
| `ResourcePermissionSourceOwner` | owner                           |
| `ResourcePermissionSourceGrant` | grant                           |
| `ResourcePermissionSourceTeam`  | team                            |
| `ResourcePermissionSourceNone`  | none                            |