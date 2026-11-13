# GetVectorStoreConnectorTrigger

What started the run: the interval, a sync request, creation with stores, a store being linked, or a rule change.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.GetVectorStoreConnectorTriggerSchedule

// Open enum: custom values can be created with a direct type cast
custom := operations.GetVectorStoreConnectorTrigger("custom_value")
```


## Values

| Name                                         | Value                                        |
| -------------------------------------------- | -------------------------------------------- |
| `GetVectorStoreConnectorTriggerSchedule`     | schedule                                     |
| `GetVectorStoreConnectorTriggerManual`       | manual                                       |
| `GetVectorStoreConnectorTriggerCreated`      | created                                      |
| `GetVectorStoreConnectorTriggerLinked`       | linked                                       |
| `GetVectorStoreConnectorTriggerRulesChanged` | rules_changed                                |