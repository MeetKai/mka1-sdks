# VectorStoreStatus

The status of the vector store. 'expired' means the store has expired, 'in_progress' means files are still being processed, 'completed' indicates that the vector store is ready for use.

## Example Usage

```python
from meetkai_mka1.models import VectorStoreStatus

# Open enum: unrecognized values are captured as UnrecognizedStr
value: VectorStoreStatus = "expired"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"expired"`
- `"in_progress"`
- `"completed"`
