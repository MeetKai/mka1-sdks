# GetVectorStoreConnectorRunTrigger

What started the run: the interval, a sync request, creation with stores, a store being linked, or a rule change.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.GetVectorStoreConnectorRunTriggerSchedule

// Open enum: custom values can be created with a direct type cast
custom := operations.GetVectorStoreConnectorRunTrigger("custom_value")
```


## Values

| Name                                            | Value                                           |
| ----------------------------------------------- | ----------------------------------------------- |
| `GetVectorStoreConnectorRunTriggerSchedule`     | schedule                                        |
| `GetVectorStoreConnectorRunTriggerManual`       | manual                                          |
| `GetVectorStoreConnectorRunTriggerCreated`      | created                                         |
| `GetVectorStoreConnectorRunTriggerLinked`       | linked                                          |
| `GetVectorStoreConnectorRunTriggerRulesChanged` | rules_changed                                   |