# ListResponseFeedbackOrder

The order to return feedback entries in by creation date of the underlying request. 'asc' returns oldest first, 'desc' returns newest first. Defaults to 'desc' (newest first).

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.ListResponseFeedbackOrderAsc
```


## Values

| Name                            | Value                           |
| ------------------------------- | ------------------------------- |
| `ListResponseFeedbackOrderAsc`  | asc                             |
| `ListResponseFeedbackOrderDesc` | desc                            |