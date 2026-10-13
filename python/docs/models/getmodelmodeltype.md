# GetModelModelType

## Example Usage

```python
from meetkai_mka1.models import GetModelModelType

# Open enum: unrecognized values are captured as UnrecognizedStr
value: GetModelModelType = "llm"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"llm"`
- `"embeddings"`
- `"images"`
- `"speech_to_text"`
- `"text_to_speech"`
