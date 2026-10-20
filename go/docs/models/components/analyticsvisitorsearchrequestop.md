# AnalyticsVisitorSearchRequestOp

Comparison operator. gt, gte, lt, and lte require a numeric value. exists and not_exists check whether the property is present and do not take a value.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.AnalyticsVisitorSearchRequestOpEq
```


## Values

| Name                                       | Value                                      |
| ------------------------------------------ | ------------------------------------------ |
| `AnalyticsVisitorSearchRequestOpEq`        | eq                                         |
| `AnalyticsVisitorSearchRequestOpNeq`       | neq                                        |
| `AnalyticsVisitorSearchRequestOpGt`        | gt                                         |
| `AnalyticsVisitorSearchRequestOpGte`       | gte                                        |
| `AnalyticsVisitorSearchRequestOpLt`        | lt                                         |
| `AnalyticsVisitorSearchRequestOpLte`       | lte                                        |
| `AnalyticsVisitorSearchRequestOpExists`    | exists                                     |
| `AnalyticsVisitorSearchRequestOpNotExists` | not_exists                                 |