# ImportAgentRunRequestStatus

`failed` means no score was produced at all. An agent timeout is NOT that — the harness still runs the verifier and scores the trial, so it stays `completed` and carries its exception in `error`.

## Example Usage

```python
from meetkai_mka1.models import ImportAgentRunRequestStatus
value: ImportAgentRunRequestStatus = "completed"
```


## Values

- `"completed"`
- `"failed"`
