# CodingHarnessStopReason

Why a Coding Harness allocation entered ``stopped``.

Recorded on the session row at the stop transition and cleared by resume,
so a client that finds a stopped session can say whether the owner
suspended it, the idle or absolute clock ran out, or the runner released
it. Every value is resumable; termination is a different status.

## Example Usage

```python
from meetkai_mka1.models import CodingHarnessStopReason

# Open enum: unrecognized values are captured as UnrecognizedStr
value: CodingHarnessStopReason = "user_suspend"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"user_suspend"`
- `"idle_expired"`
- `"absolute_expired"`
- `"runner_drain"`
- `"runner_recovery"`
