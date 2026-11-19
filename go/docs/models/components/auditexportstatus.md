# AuditExportStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.AuditExportStatusPending

// Open enum: custom values can be created with a direct type cast
custom := components.AuditExportStatus("custom_value")
```


## Values

| Name                         | Value                        |
| ---------------------------- | ---------------------------- |
| `AuditExportStatusPending`   | pending                      |
| `AuditExportStatusRunning`   | running                      |
| `AuditExportStatusCompleted` | completed                    |
| `AuditExportStatusFailed`    | failed                       |
| `AuditExportStatusExpired`   | expired                      |