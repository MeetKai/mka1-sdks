# CreateVectorStoreConnectorTrigger

What started the run: the interval, a sync request, creation with stores, a store being linked, or a rule change.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.CreateVectorStoreConnectorTriggerSchedule

// Open enum: custom values can be created with a direct type cast
custom := operations.CreateVectorStoreConnectorTrigger("custom_value")
```


## Values

| Name                                            | Value                                           |
| ----------------------------------------------- | ----------------------------------------------- |
| `CreateVectorStoreConnectorTriggerSchedule`     | schedule                                        |
| `CreateVectorStoreConnectorTriggerManual`       | manual                                          |
| `CreateVectorStoreConnectorTriggerCreated`      | created                                         |
| `CreateVectorStoreConnectorTriggerLinked`       | linked                                          |
| `CreateVectorStoreConnectorTriggerRulesChanged` | rules_changed                                   |