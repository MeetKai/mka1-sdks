# CodingHarnessStopReason

Why a Coding Harness allocation entered ``stopped``.

Recorded on the session row at the stop transition and cleared by resume,
so a client that finds a stopped session can say whether the owner
suspended it, the idle or absolute clock ran out, or the runner released
it. Every value is resumable; termination is a different status.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = CodingHarnessStopReason.UserSuspend;
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `UserSuspend`     | user_suspend      |
| `IdleExpired`     | idle_expired      |
| `AbsoluteExpired` | absolute_expired  |
| `RunnerDrain`     | runner_drain      |
| `RunnerRecovery`  | runner_recovery   |