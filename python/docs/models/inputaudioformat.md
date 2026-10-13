# InputAudioFormat

The audio format/codec. Supported formats are 'mp3' and 'wav'.

## Example Usage

```python
from meetkai_mka1.models import InputAudioFormat

# Open enum: unrecognized values are captured as UnrecognizedStr
value: InputAudioFormat = "mp3"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"mp3"`
- `"wav"`
