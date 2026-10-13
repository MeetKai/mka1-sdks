# OutputMessageWithIDStatus

The processing status of this message (in_progress, completed, or incomplete).

## Example Usage

```python
from meetkai_mka1.models import OutputMessageWithIDStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: OutputMessageWithIDStatus = "in_progress"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"in_progress"`
- `"completed"`
- `"incomplete"`
