# GroundednessConfigOnError

Fail the response or skip this rule when the judge cannot evaluate

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.GroundednessConfigOnErrorFailClosed

// Open enum: custom values can be created with a direct type cast
custom := components.GroundednessConfigOnError("custom_value")
```


## Values

| Name                                  | Value                                 |
| ------------------------------------- | ------------------------------------- |
| `GroundednessConfigOnErrorFailClosed` | fail_closed                           |
| `GroundednessConfigOnErrorFailOpen`   | fail_open                             |