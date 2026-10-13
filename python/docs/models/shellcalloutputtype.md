# ShellCallOutputType

Whether the command exited normally or timed out.

## Example Usage

```python
from meetkai_mka1.models import ShellCallOutputType

# Open enum: unrecognized values are captured as UnrecognizedStr
value: ShellCallOutputType = "exit"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"exit"`
- `"timeout"`
