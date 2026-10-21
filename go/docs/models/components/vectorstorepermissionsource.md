# VectorStorePermissionSource

Where the role comes from: the store's owner, a permission held by this principal, the store's `team` permission, or nothing — the principal reaches the store only as an org admin of its team, if at all.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.VectorStorePermissionSourceOwner

// Open enum: custom values can be created with a direct type cast
custom := components.VectorStorePermissionSource("custom_value")
```


## Values

| Name                               | Value                              |
| ---------------------------------- | ---------------------------------- |
| `VectorStorePermissionSourceOwner` | owner                              |
| `VectorStorePermissionSourceGrant` | grant                              |
| `VectorStorePermissionSourceTeam`  | team                               |
| `VectorStorePermissionSourceNone`  | none                               |