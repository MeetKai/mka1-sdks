# AutoEndpoint

## Example Usage

```python
from meetkai_mka1.models import AutoEndpoint

# Open enum: unrecognized values are captured as UnrecognizedStr
value: AutoEndpoint = "responses"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"responses"`
- `"completions"`
- `"embeddings"`
- `"images"`
- `"transcriptions"`
- `"tts"`
