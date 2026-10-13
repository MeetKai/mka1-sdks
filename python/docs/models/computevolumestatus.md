# ComputeVolumeStatus

## Example Usage

```python
from meetkai_mka1.models import ComputeVolumeStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: ComputeVolumeStatus = "provisioning"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"provisioning"`
- `"loading"`
- `"ready"`
- `"deleting"`
- `"deleted"`
- `"failed"`
