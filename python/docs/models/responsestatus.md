# ResponseStatus

The overall status of the response generation. 'completed' means successfully finished, 'failed' means error occurred, 'in_progress' means currently processing, 'cancelled' means user-cancelled, 'queued' means waiting to start, 'incomplete' means partial completion.

## Example Usage

```python
from meetkai_mka1.models import ResponseStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: ResponseStatus = "completed"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"completed"`
- `"failed"`
- `"in_progress"`
- `"cancelled"`
- `"queued"`
- `"incomplete"`
