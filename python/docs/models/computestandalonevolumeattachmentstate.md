# ComputeStandaloneVolumeAttachmentState

## Example Usage

```python
from meetkai_mka1.models import ComputeStandaloneVolumeAttachmentState

# Open enum: unrecognized values are captured as UnrecognizedStr
value: ComputeStandaloneVolumeAttachmentState = "reserved"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"reserved"`
- `"attaching"`
- `"attached"`
- `"releasing"`
- `"released"`
- `"failed"`
