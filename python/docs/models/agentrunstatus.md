# AgentRunStatus

## Example Usage

```python
from meetkai_mka1.models import AgentRunStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: AgentRunStatus = "queued"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"queued"`
- `"submitting"`
- `"completed"`
- `"failed"`
