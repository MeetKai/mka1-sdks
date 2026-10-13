# Code

One of server_error, unsupported_file, or invalid_file.

## Example Usage

```python
from meetkai_mka1.models import Code

# Open enum: unrecognized values are captured as UnrecognizedStr
value: Code = "server_error"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"server_error"`
- `"unsupported_file"`
- `"invalid_file"`
