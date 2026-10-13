# VectorStoreFileBatchStatus

The status of the vector store files batch. 'in_progress' means files are being processed, 'completed' means all files have been processed, 'cancelled' means the batch was cancelled, 'failed' means the batch failed.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = VectorStoreFileBatchStatus.InProgress;
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `InProgress` | in_progress  |
| `Completed`  | completed    |
| `Cancelled`  | cancelled    |
| `Failed`     | failed       |