# VectorStorePermissionGranteeType

Who the permission applies to: one principal (`user`), or every member of the store's team (`team`).

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.VectorStorePermissionGranteeTypeUser

// Open enum: custom values can be created with a direct type cast
custom := components.VectorStorePermissionGranteeType("custom_value")
```


## Values

| Name                                   | Value                                  |
| -------------------------------------- | -------------------------------------- |
| `VectorStorePermissionGranteeTypeUser` | user                                   |
| `VectorStorePermissionGranteeTypeTeam` | team                                   |