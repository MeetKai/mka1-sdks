# LinkVectorStoreConnectorTrigger

What started the run: the interval, a sync request, creation with stores, a store being linked, or a rule change.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.LinkVectorStoreConnectorTriggerSchedule

// Open enum: custom values can be created with a direct type cast
custom := operations.LinkVectorStoreConnectorTrigger("custom_value")
```


## Values

| Name                                          | Value                                         |
| --------------------------------------------- | --------------------------------------------- |
| `LinkVectorStoreConnectorTriggerSchedule`     | schedule                                      |
| `LinkVectorStoreConnectorTriggerManual`       | manual                                        |
| `LinkVectorStoreConnectorTriggerCreated`      | created                                       |
| `LinkVectorStoreConnectorTriggerLinked`       | linked                                        |
| `LinkVectorStoreConnectorTriggerRulesChanged` | rules_changed                                 |