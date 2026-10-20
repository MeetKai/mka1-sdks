# Stream

The stream the line was written to. Native services report one combined stream as stdout: Kubernetes merges a container's two streams.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.StreamStdout

// Open enum: custom values can be created with a direct type cast
custom := components.Stream("custom_value")
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `StreamStdout` | stdout         |
| `StreamStderr` | stderr         |