# UpdateVectorStoreConnectorTrigger

What started the run: the interval, a sync request, creation with stores, a store being linked, or a rule change.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.UpdateVectorStoreConnectorTriggerSchedule

// Open enum: custom values can be created with a direct type cast
custom := operations.UpdateVectorStoreConnectorTrigger("custom_value")
```


## Values

| Name                                            | Value                                           |
| ----------------------------------------------- | ----------------------------------------------- |
| `UpdateVectorStoreConnectorTriggerSchedule`     | schedule                                        |
| `UpdateVectorStoreConnectorTriggerManual`       | manual                                          |
| `UpdateVectorStoreConnectorTriggerCreated`      | created                                         |
| `UpdateVectorStoreConnectorTriggerLinked`       | linked                                          |
| `UpdateVectorStoreConnectorTriggerRulesChanged` | rules_changed                                   |