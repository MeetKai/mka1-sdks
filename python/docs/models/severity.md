# Severity

Whether an issue stops a consumer (`ERROR`) or is for a human to look at (`WARNING`).

## Example Usage

```python
from meetkai_mka1.models import Severity

# Open enum: unrecognized values are captured as UnrecognizedStr
value: Severity = "error"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"error"`
- `"warning"`
