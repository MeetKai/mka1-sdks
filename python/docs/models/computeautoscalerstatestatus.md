# ComputeAutoscalerStateStatus

## Example Usage

```python
from meetkai_mka1.models import ComputeAutoscalerStateStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: ComputeAutoscalerStateStatus = "disabled"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"disabled"`
- `"active"`
- `"cooling_down"`
- `"blocked"`
- `"unknown"`
