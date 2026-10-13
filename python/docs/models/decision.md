# Decision

## Example Usage

```python
from meetkai_mka1.models import Decision

# Open enum: unrecognized values are captured as UnrecognizedStr
value: Decision = "create"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"create"`
- `"manual"`
- `"autoscaler"`
