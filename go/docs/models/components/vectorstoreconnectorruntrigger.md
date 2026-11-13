# VectorStoreConnectorRunTrigger

What started the run: the interval, a sync request, creation with stores, a store being linked, or a rule change.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.VectorStoreConnectorRunTriggerSchedule

// Open enum: custom values can be created with a direct type cast
custom := components.VectorStoreConnectorRunTrigger("custom_value")
```


## Values

| Name                                         | Value                                        |
| -------------------------------------------- | -------------------------------------------- |
| `VectorStoreConnectorRunTriggerSchedule`     | schedule                                     |
| `VectorStoreConnectorRunTriggerManual`       | manual                                       |
| `VectorStoreConnectorRunTriggerCreated`      | created                                      |
| `VectorStoreConnectorRunTriggerLinked`       | linked                                       |
| `VectorStoreConnectorRunTriggerRulesChanged` | rules_changed                                |