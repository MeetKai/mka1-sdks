# OutputAudioItemStatus

The processing status of this audio item.

## Example Usage

```python
from meetkai_mka1.models import OutputAudioItemStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: OutputAudioItemStatus = "in_progress"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"in_progress"`
- `"completed"`
- `"incomplete"`
