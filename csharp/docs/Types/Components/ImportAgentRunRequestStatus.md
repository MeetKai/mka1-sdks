# ImportAgentRunRequestStatus

`failed` means no score was produced at all. An agent timeout is NOT that — the harness still runs the verifier and scores the trial, so it stays `completed` and carries its exception in `error`.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = ImportAgentRunRequestStatus.Completed;
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Completed` | completed   |
| `Failed`    | failed      |