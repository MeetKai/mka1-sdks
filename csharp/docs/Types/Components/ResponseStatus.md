# ResponseStatus

The overall status of the response generation. 'completed' means successfully finished, 'failed' means error occurred, 'in_progress' means currently processing, 'cancelled' means user-cancelled, 'queued' means waiting to start, 'incomplete' means partial completion.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = ResponseStatus.Completed;
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Completed`  | completed    |
| `Failed`     | failed       |
| `InProgress` | in_progress  |
| `Cancelled`  | cancelled    |
| `Queued`     | queued       |
| `Incomplete` | incomplete   |