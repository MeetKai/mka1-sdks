# ExportResponseFeedbackOrder

The order to export feedback entries in by creation date of the underlying request. 'asc' exports oldest first, 'desc' exports newest first. Defaults to 'desc' (newest first).

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.ExportResponseFeedbackOrderAsc
```


## Values

| Name                              | Value                             |
| --------------------------------- | --------------------------------- |
| `ExportResponseFeedbackOrderAsc`  | asc                               |
| `ExportResponseFeedbackOrderDesc` | desc                              |