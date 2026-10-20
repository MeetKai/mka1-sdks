# ManagedServiceStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.ManagedServiceStatusStarting

// Open enum: custom values can be created with a direct type cast
custom := components.ManagedServiceStatus("custom_value")
```


## Values

| Name                            | Value                           |
| ------------------------------- | ------------------------------- |
| `ManagedServiceStatusStarting`  | starting                        |
| `ManagedServiceStatusReady`     | ready                           |
| `ManagedServiceStatusUnhealthy` | unhealthy                       |
| `ManagedServiceStatusStopped`   | stopped                         |