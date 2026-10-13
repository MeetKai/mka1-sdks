# OutputMessageStatus

The processing status of this message (in_progress, completed, or incomplete).

## Example Usage

```python
from meetkai_mka1.models import OutputMessageStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: OutputMessageStatus = "in_progress"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"in_progress"`
- `"completed"`
- `"incomplete"`
