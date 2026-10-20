# AnalyticsEventSearchRequestOp

Comparison operator. gt, gte, lt, and lte require a numeric value. exists and not_exists check whether the property is present and do not take a value.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.AnalyticsEventSearchRequestOpEq
```


## Values

| Name                                     | Value                                    |
| ---------------------------------------- | ---------------------------------------- |
| `AnalyticsEventSearchRequestOpEq`        | eq                                       |
| `AnalyticsEventSearchRequestOpNeq`       | neq                                      |
| `AnalyticsEventSearchRequestOpGt`        | gt                                       |
| `AnalyticsEventSearchRequestOpGte`       | gte                                      |
| `AnalyticsEventSearchRequestOpLt`        | lt                                       |
| `AnalyticsEventSearchRequestOpLte`       | lte                                      |
| `AnalyticsEventSearchRequestOpExists`    | exists                                   |
| `AnalyticsEventSearchRequestOpNotExists` | not_exists                               |