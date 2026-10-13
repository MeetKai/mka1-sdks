# Operation

## Example Usage

```python
from meetkai_mka1.models import Operation

# Open enum: unrecognized values are captured as UnrecognizedStr
value: Operation = "eq"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"eq"`
- `"ne"`
- `"like"`
- `"ilike"`
