# VectorStoreStatus

The status of the vector store. 'expired' means the store has expired, 'in_progress' means files are still being processed, 'completed' indicates that the vector store is ready for use.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = VectorStoreStatus.Expired;
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Expired`    | expired      |
| `InProgress` | in_progress  |
| `Completed`  | completed    |