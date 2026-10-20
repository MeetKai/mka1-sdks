# AnalyticsQueryRequestOp

Comparison operator. gt, gte, lt, and lte require a numeric value. exists and not_exists check whether the property is present and do not take a value.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.AnalyticsQueryRequestOpEq
```


## Values

| Name                               | Value                              |
| ---------------------------------- | ---------------------------------- |
| `AnalyticsQueryRequestOpEq`        | eq                                 |
| `AnalyticsQueryRequestOpNeq`       | neq                                |
| `AnalyticsQueryRequestOpGt`        | gt                                 |
| `AnalyticsQueryRequestOpGte`       | gte                                |
| `AnalyticsQueryRequestOpLt`        | lt                                 |
| `AnalyticsQueryRequestOpLte`       | lte                                |
| `AnalyticsQueryRequestOpExists`    | exists                             |
| `AnalyticsQueryRequestOpNotExists` | not_exists                         |