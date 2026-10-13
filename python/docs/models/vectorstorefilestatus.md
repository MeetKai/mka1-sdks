# VectorStoreFileStatus

The status of the vector store file. 'in_progress' means currently processing, 'completed' indicates the file is ready for use, 'cancelled' means processing was cancelled, 'failed' means an error occurred.

## Example Usage

```python
from meetkai_mka1.models import VectorStoreFileStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: VectorStoreFileStatus = "in_progress"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"in_progress"`
- `"completed"`
- `"cancelled"`
- `"failed"`
