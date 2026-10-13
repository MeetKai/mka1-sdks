# SandboxProvider

## Example Usage

```python
from meetkai_mka1.models import SandboxProvider

# Open enum: unrecognized values are captured as UnrecognizedStr
value: SandboxProvider = "in-memory"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"in-memory"`
- `"runner-process"`
- `"runner-docker"`
- `"runner-firecracker"`
