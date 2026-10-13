# SandboxFeature

## Example Usage

```python
from meetkai_mka1.models import SandboxFeature

# Open enum: unrecognized values are captured as UnrecognizedStr
value: SandboxFeature = "python"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"python"`
- `"git"`
- `"claude-code"`
