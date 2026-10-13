# FeatureFlagValueType

## Example Usage

```python
from meetkai_mka1.models import FeatureFlagValueType

# Open enum: unrecognized values are captured as UnrecognizedStr
value: FeatureFlagValueType = "boolean"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"boolean"`
- `"string"`
- `"number"`
- `"json"`
