# ListVectorStoreConnectorRunsTrigger

What started the run: the interval, a sync request, creation with stores, a store being linked, or a rule change.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.ListVectorStoreConnectorRunsTriggerSchedule

// Open enum: custom values can be created with a direct type cast
custom := operations.ListVectorStoreConnectorRunsTrigger("custom_value")
```


## Values

| Name                                              | Value                                             |
| ------------------------------------------------- | ------------------------------------------------- |
| `ListVectorStoreConnectorRunsTriggerSchedule`     | schedule                                          |
| `ListVectorStoreConnectorRunsTriggerManual`       | manual                                            |
| `ListVectorStoreConnectorRunsTriggerCreated`      | created                                           |
| `ListVectorStoreConnectorRunsTriggerLinked`       | linked                                            |
| `ListVectorStoreConnectorRunsTriggerRulesChanged` | rules_changed                                     |