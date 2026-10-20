# FeatureFlagOperator

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.FeatureFlagOperatorEq

// Open enum: custom values can be created with a direct type cast
custom := components.FeatureFlagOperator("custom_value")
```


## Values

| Name                             | Value                            |
| -------------------------------- | -------------------------------- |
| `FeatureFlagOperatorEq`          | eq                               |
| `FeatureFlagOperatorNeq`         | neq                              |
| `FeatureFlagOperatorIn`          | in                               |
| `FeatureFlagOperatorNotIn`       | not_in                           |
| `FeatureFlagOperatorContains`    | contains                         |
| `FeatureFlagOperatorNotContains` | not_contains                     |
| `FeatureFlagOperatorGt`          | gt                               |
| `FeatureFlagOperatorGte`         | gte                              |
| `FeatureFlagOperatorLt`          | lt                               |
| `FeatureFlagOperatorLte`         | lte                              |
| `FeatureFlagOperatorExists`      | exists                           |
| `FeatureFlagOperatorNotExists`   | not_exists                       |