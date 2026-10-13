# OutputAudioItemWithIDStatus

The processing status of this audio item.

## Example Usage

```python
from meetkai_mka1.models import OutputAudioItemWithIDStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: OutputAudioItemWithIDStatus = "in_progress"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"in_progress"`
- `"completed"`
- `"incomplete"`
