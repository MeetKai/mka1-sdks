# FeatureFlagOperator

## Example Usage

```python
from meetkai_mka1.models import FeatureFlagOperator

# Open enum: unrecognized values are captured as UnrecognizedStr
value: FeatureFlagOperator = "eq"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"eq"`
- `"neq"`
- `"in"`
- `"not_in"`
- `"contains"`
- `"not_contains"`
- `"gt"`
- `"gte"`
- `"lt"`
- `"lte"`
- `"exists"`
- `"not_exists"`
