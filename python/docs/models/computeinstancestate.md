# ComputeInstanceState

## Example Usage

```python
from meetkai_mka1.models import ComputeInstanceState

# Open enum: unrecognized values are captured as UnrecognizedStr
value: ComputeInstanceState = "requested"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"requested"`
- `"starting"`
- `"running"`
- `"ready"`
- `"busy"`
- `"stopping"`
- `"stopped"`
- `"succeeded"`
- `"failed"`
- `"lost"`
- `"unknown"`
