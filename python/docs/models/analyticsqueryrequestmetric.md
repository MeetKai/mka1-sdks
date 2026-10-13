# AnalyticsQueryRequestMetric

count counts events. unique_visitors counts distinct values of distinct_id. Both deduplicate event IDs first.

## Example Usage

```python
from meetkai_mka1.models import AnalyticsQueryRequestMetric
value: AnalyticsQueryRequestMetric = "count"
```


## Values

- `"count"`
- `"unique_visitors"`
