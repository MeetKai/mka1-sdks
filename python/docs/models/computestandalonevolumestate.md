# ComputeStandaloneVolumeState

## Example Usage

```python
from meetkai_mka1.models import ComputeStandaloneVolumeState

# Open enum: unrecognized values are captured as UnrecognizedStr
value: ComputeStandaloneVolumeState = "creating"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"creating"`
- `"ready"`
- `"deleting"`
- `"deleted"`
- `"failed"`
