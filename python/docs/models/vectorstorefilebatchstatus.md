# VectorStoreFileBatchStatus

The status of the vector store files batch. 'in_progress' means files are being processed, 'completed' means all files have been processed, 'cancelled' means the batch was cancelled, 'failed' means the batch failed.

## Example Usage

```python
from meetkai_mka1.models import VectorStoreFileBatchStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: VectorStoreFileBatchStatus = "in_progress"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"in_progress"`
- `"completed"`
- `"cancelled"`
- `"failed"`
