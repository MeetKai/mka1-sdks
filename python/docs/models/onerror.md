# OnError

Stop the request or skip this classifier when evaluation fails

## Example Usage

```python
from meetkai_mka1.models import OnError

# Open enum: unrecognized values are captured as UnrecognizedStr
value: OnError = "fail_closed"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"fail_closed"`
- `"fail_open"`
