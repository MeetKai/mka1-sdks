# AnalyticsQueryRequestMetric

count counts events. unique_visitors counts distinct values of distinct_id. Both deduplicate event IDs first.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.AnalyticsQueryRequestMetricCount
```


## Values

| Name                                        | Value                                       |
| ------------------------------------------- | ------------------------------------------- |
| `AnalyticsQueryRequestMetricCount`          | count                                       |
| `AnalyticsQueryRequestMetricUniqueVisitors` | unique_visitors                             |