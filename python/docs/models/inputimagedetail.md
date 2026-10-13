# InputImageDetail

The detail level for image processing. 'high' for detailed analysis (higher cost), 'low' for basic analysis (lower cost), 'auto' lets the model choose based on image size, 'original' asks for the image at its native resolution (treated as 'high' by upstreams without that level). Defaults to 'auto'.

## Example Usage

```python
from meetkai_mka1.models import InputImageDetail

# Open enum: unrecognized values are captured as UnrecognizedStr
value: InputImageDetail = "high"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"high"`
- `"low"`
- `"auto"`
- `"original"`
