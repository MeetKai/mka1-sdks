# SessionStatus

## Example Usage

```python
from meetkai_mka1.models import SessionStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: SessionStatus = "queued"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"queued"`
- `"pending"`
- `"provisioning"`
- `"running"`
- `"idle"`
- `"stopping"`
- `"stopped"`
- `"failed"`
- `"terminated"`
