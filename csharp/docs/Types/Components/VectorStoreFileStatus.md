# VectorStoreFileStatus

The status of the vector store file. 'in_progress' means currently processing, 'completed' indicates the file is ready for use, 'cancelled' means processing was cancelled, 'failed' means an error occurred.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = VectorStoreFileStatus.InProgress;
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `InProgress` | in_progress  |
| `Completed`  | completed    |
| `Cancelled`  | cancelled    |
| `Failed`     | failed       |