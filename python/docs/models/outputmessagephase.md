# OutputMessagePhase

Labels an assistant message as intermediate commentary or the final answer.

## Example Usage

```python
from meetkai_mka1.models import OutputMessagePhase

# Open enum: unrecognized values are captured as UnrecognizedStr
value: OutputMessagePhase = "commentary"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"commentary"`
- `"final_answer"`
