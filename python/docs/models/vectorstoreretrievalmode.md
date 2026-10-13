# VectorStoreRetrievalMode

Retrieval mode, frozen at creation. 'vector': standard vector similarity search. 'graph': GraphRAG — entities and relations are extracted at ingest and queries traverse the knowledge graph. 'hybrid' is reserved.

## Example Usage

```python
from meetkai_mka1.models import VectorStoreRetrievalMode

# Open enum: unrecognized values are captured as UnrecognizedStr
value: VectorStoreRetrievalMode = "vector"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"vector"`
- `"hybrid"`
- `"graph"`
