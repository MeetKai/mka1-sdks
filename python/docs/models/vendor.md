# Vendor

Present on every gpu-class entry, absent on cpu-class entries.

## Example Usage

```python
from meetkai_mka1.models import Vendor

# Open enum: unrecognized values are captured as UnrecognizedStr
value: Vendor = "nvidia"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"nvidia"`
- `"amd"`
