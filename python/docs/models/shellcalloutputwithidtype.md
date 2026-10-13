# ShellCallOutputWithIDType

Whether the command exited normally or timed out.

## Example Usage

```python
from meetkai_mka1.models import ShellCallOutputWithIDType

# Open enum: unrecognized values are captured as UnrecognizedStr
value: ShellCallOutputWithIDType = "exit"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"exit"`
- `"timeout"`
