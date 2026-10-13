# Purpose

The intended purpose of the file

## Example Usage

```python
from meetkai_mka1.models import Purpose

# Open enum: unrecognized values are captured as UnrecognizedStr
value: Purpose = "assistants"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"assistants"`
- `"batch"`
- `"fine-tune"`
- `"vision"`
- `"user_data"`
- `"evals"`
