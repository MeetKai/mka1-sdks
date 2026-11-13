# SyncVectorStoreConnectorTrigger

What started the run: the interval, a sync request, creation with stores, a store being linked, or a rule change.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.SyncVectorStoreConnectorTriggerSchedule

// Open enum: custom values can be created with a direct type cast
custom := operations.SyncVectorStoreConnectorTrigger("custom_value")
```


## Values

| Name                                          | Value                                         |
| --------------------------------------------- | --------------------------------------------- |
| `SyncVectorStoreConnectorTriggerSchedule`     | schedule                                      |
| `SyncVectorStoreConnectorTriggerManual`       | manual                                        |
| `SyncVectorStoreConnectorTriggerCreated`      | created                                       |
| `SyncVectorStoreConnectorTriggerLinked`       | linked                                        |
| `SyncVectorStoreConnectorTriggerRulesChanged` | rules_changed                                 |