# MCPAuthType

## Example Usage

```python
from meetkai_mka1.models import MCPAuthType

# Open enum: unrecognized values are captured as UnrecognizedStr
value: MCPAuthType = "bearer"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"bearer"`
- `"authorization"`
- `"headers"`
- `"none"`
