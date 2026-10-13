# InputMessageRole

The role of the message sender (user, assistant, system, or developer).

## Example Usage

```python
from meetkai_mka1.models import InputMessageRole

# Open enum: unrecognized values are captured as UnrecognizedStr
value: InputMessageRole = "user"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"user"`
- `"assistant"`
- `"system"`
- `"developer"`
