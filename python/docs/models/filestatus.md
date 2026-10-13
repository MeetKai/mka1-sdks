# FileStatus

DEPRECATED: File processing status

## Example Usage

```python
from meetkai_mka1.models import FileStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: FileStatus = "uploaded"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"uploaded"`
- `"processed"`
- `"error"`
