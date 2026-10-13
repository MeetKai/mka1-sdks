# Status

The processing status of an individual item. 'in_progress' means currently processing, 'completed' means finished successfully, 'incomplete' means processing stopped before completion.

## Example Usage

```python
from meetkai_mka1.models import Status

# Open enum: unrecognized values are captured as UnrecognizedStr
value: Status = "in_progress"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"in_progress"`
- `"completed"`
- `"incomplete"`
