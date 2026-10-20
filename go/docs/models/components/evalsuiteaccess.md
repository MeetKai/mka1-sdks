# EvalSuiteAccess

`owner` when the suite belongs to the caller's org and team; `shared` when it is visible only through a read-only share to the caller's org.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.EvalSuiteAccessOwner

// Open enum: custom values can be created with a direct type cast
custom := components.EvalSuiteAccess("custom_value")
```


## Values

| Name                    | Value                   |
| ----------------------- | ----------------------- |
| `EvalSuiteAccessOwner`  | owner                   |
| `EvalSuiteAccessShared` | shared                  |