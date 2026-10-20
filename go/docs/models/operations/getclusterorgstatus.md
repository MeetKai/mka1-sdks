# GetClusterOrgStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.GetClusterOrgStatusActive

// Open enum: custom values can be created with a direct type cast
custom := operations.GetClusterOrgStatus("custom_value")
```


## Values

| Name                           | Value                          |
| ------------------------------ | ------------------------------ |
| `GetClusterOrgStatusActive`    | active                         |
| `GetClusterOrgStatusSuspended` | suspended                      |
| `GetClusterOrgStatusDeleted`   | deleted                        |