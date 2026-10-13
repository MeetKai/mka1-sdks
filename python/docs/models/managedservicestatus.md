# ManagedServiceStatus

## Example Usage

```python
from meetkai_mka1.models import ManagedServiceStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: ManagedServiceStatus = "starting"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"starting"`
- `"ready"`
- `"unhealthy"`
- `"stopped"`
