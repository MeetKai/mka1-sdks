# EffectivePriceRowSource

## Example Usage

```python
from meetkai_mka1.models import EffectivePriceRowSource

# Open enum: unrecognized values are captured as UnrecognizedStr
value: EffectivePriceRowSource = "org_override"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"org_override"`
- `"cluster_default"`
- `"unpriced"`
- `"auto"`
