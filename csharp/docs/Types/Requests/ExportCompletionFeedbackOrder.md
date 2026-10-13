# ExportCompletionFeedbackOrder

The order to export feedback entries in by creation date of the underlying request. 'asc' exports oldest first, 'desc' exports newest first. Defaults to 'desc' (newest first).

## Example Usage

```csharp
using MeetKai.MKA1.Types.Requests;

var value = ExportCompletionFeedbackOrder.Asc;
```


## Values

| Name   | Value  |
| ------ | ------ |
| `Asc`  | asc    |
| `Desc` | desc   |