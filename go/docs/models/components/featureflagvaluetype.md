# FeatureFlagValueType

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.FeatureFlagValueTypeBoolean

// Open enum: custom values can be created with a direct type cast
custom := components.FeatureFlagValueType("custom_value")
```


## Values

| Name                          | Value                         |
| ----------------------------- | ----------------------------- |
| `FeatureFlagValueTypeBoolean` | boolean                       |
| `FeatureFlagValueTypeString`  | string                        |
| `FeatureFlagValueTypeNumber`  | number                        |
| `FeatureFlagValueTypeJSON`    | json                          |