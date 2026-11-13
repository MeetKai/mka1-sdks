# ListVectorStoreConnectorsTrigger

What started the run: the interval, a sync request, creation with stores, a store being linked, or a rule change.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.ListVectorStoreConnectorsTriggerSchedule

// Open enum: custom values can be created with a direct type cast
custom := operations.ListVectorStoreConnectorsTrigger("custom_value")
```


## Values

| Name                                           | Value                                          |
| ---------------------------------------------- | ---------------------------------------------- |
| `ListVectorStoreConnectorsTriggerSchedule`     | schedule                                       |
| `ListVectorStoreConnectorsTriggerManual`       | manual                                         |
| `ListVectorStoreConnectorsTriggerCreated`      | created                                        |
| `ListVectorStoreConnectorsTriggerLinked`       | linked                                         |
| `ListVectorStoreConnectorsTriggerRulesChanged` | rules_changed                                  |