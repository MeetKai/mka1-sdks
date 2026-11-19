# AuditExportQueuedStatus

running when the same export was already under way.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.AuditExportQueuedStatusPending

// Open enum: custom values can be created with a direct type cast
custom := components.AuditExportQueuedStatus("custom_value")
```


## Values

| Name                             | Value                            |
| -------------------------------- | -------------------------------- |
| `AuditExportQueuedStatusPending` | pending                          |
| `AuditExportQueuedStatusRunning` | running                          |