# SupportCaseStatus

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.SupportCaseStatusOpen

// Open enum: custom values can be created with a direct type cast
custom := components.SupportCaseStatus("custom_value")
```


## Values

| Name                                 | Value                                |
| ------------------------------------ | ------------------------------------ |
| `SupportCaseStatusOpen`              | open                                 |
| `SupportCaseStatusWaitingOnCustomer` | waiting_on_customer                  |
| `SupportCaseStatusResolved`          | resolved                             |