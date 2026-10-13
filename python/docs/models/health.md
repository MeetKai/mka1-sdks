# Health

## Example Usage

```python
from meetkai_mka1.models import Health

# Open enum: unrecognized values are captured as UnrecognizedStr
value: Health = "healthy"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"healthy"`
- `"warming"`
- `"degraded"`
