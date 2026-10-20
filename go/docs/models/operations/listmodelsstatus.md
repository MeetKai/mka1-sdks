# ListModelsStatus

`active`, `deprecated` (still served, retirement announced or pending) or `retired` (the retirement date has passed). Informational in this version: the gateway does not yet refuse a retired model.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

value := operations.ListModelsStatusActive

// Open enum: custom values can be created with a direct type cast
custom := operations.ListModelsStatus("custom_value")
```


## Values

| Name                         | Value                        |
| ---------------------------- | ---------------------------- |
| `ListModelsStatusActive`     | active                       |
| `ListModelsStatusDeprecated` | deprecated                   |
| `ListModelsStatusRetired`    | retired                      |