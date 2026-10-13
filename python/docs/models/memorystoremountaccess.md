# MemoryStoreMountAccess

Whether the mounted memory store can be modified.

## Example Usage

```python
from meetkai_mka1.models import MemoryStoreMountAccess

# Open enum: unrecognized values are captured as UnrecognizedStr
value: MemoryStoreMountAccess = "read_only"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"read_only"`
- `"read_write"`
