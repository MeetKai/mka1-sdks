# AnalyticsQueryRequestOp

Comparison operator. gt, gte, lt, and lte require a numeric value. exists and not_exists check whether the property is present and do not take a value.

## Example Usage

```python
from meetkai_mka1.models import AnalyticsQueryRequestOp
value: AnalyticsQueryRequestOp = "eq"
```


## Values

- `"eq"`
- `"neq"`
- `"gt"`
- `"gte"`
- `"lt"`
- `"lte"`
- `"exists"`
- `"not_exists"`
