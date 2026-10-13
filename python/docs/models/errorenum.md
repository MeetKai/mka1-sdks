# ErrorEnum

## Example Usage

```python
from meetkai_mka1.models import ErrorEnum

# Open enum: unrecognized values are captured as UnrecognizedStr
value: ErrorEnum = "bad_request"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"bad_request"`
- `"authentication_required"`
- `"forbidden"`
- `"not_found"`
- `"conflict"`
- `"precondition_failed"`
- `"method_not_allowed"`
- `"internal"`
