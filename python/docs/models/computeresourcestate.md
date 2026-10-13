# ComputeResourceState

## Example Usage

```python
from meetkai_mka1.models import ComputeResourceState

# Open enum: unrecognized values are captured as UnrecognizedStr
value: ComputeResourceState = "requested"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"requested"`
- `"allocating"`
- `"provisioning"`
- `"running"`
- `"ready"`
- `"finalizing"`
- `"terminating"`
- `"succeeded"`
- `"failed"`
- `"terminated"`
