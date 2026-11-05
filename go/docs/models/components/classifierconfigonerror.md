# ClassifierConfigOnError

Stop the request or skip this classifier when evaluation fails

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ClassifierConfigOnErrorFailClosed

// Open enum: custom values can be created with a direct type cast
custom := components.ClassifierConfigOnError("custom_value")
```


## Values

| Name                                | Value                               |
| ----------------------------------- | ----------------------------------- |
| `ClassifierConfigOnErrorFailClosed` | fail_closed                         |
| `ClassifierConfigOnErrorFailOpen`   | fail_open                           |