# OnError

Stop the request or skip this classifier when evaluation fails

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.OnErrorFailClosed

// Open enum: custom values can be created with a direct type cast
custom := components.OnError("custom_value")
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `OnErrorFailClosed` | fail_closed         |
| `OnErrorFailOpen`   | fail_open           |