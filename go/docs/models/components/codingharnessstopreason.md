# CodingHarnessStopReason

Why a Coding Harness allocation entered ``stopped``.

Recorded on the session row at the stop transition and cleared by resume,
so a client that finds a stopped session can say whether the owner
suspended it, the idle or absolute clock ran out, or the runner released
it. Every value is resumable; termination is a different status.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.CodingHarnessStopReasonUserSuspend

// Open enum: custom values can be created with a direct type cast
custom := components.CodingHarnessStopReason("custom_value")
```


## Values

| Name                                     | Value                                    |
| ---------------------------------------- | ---------------------------------------- |
| `CodingHarnessStopReasonUserSuspend`     | user_suspend                             |
| `CodingHarnessStopReasonIdleExpired`     | idle_expired                             |
| `CodingHarnessStopReasonAbsoluteExpired` | absolute_expired                         |
| `CodingHarnessStopReasonRunnerDrain`     | runner_drain                             |
| `CodingHarnessStopReasonRunnerRecovery`  | runner_recovery                          |