# CreateVectorStoreRequestRetrievalMode

Retrieval mode, frozen at creation (cannot be changed later). 'vector' (default): standard vector similarity search. 'graph': GraphRAG — entities and relations are extracted from every chunk at ingest (metered against your usage) and search traverses the knowledge graph.

## Example Usage

```python
from meetkai_mka1.models import CreateVectorStoreRequestRetrievalMode
value: CreateVectorStoreRequestRetrievalMode = "vector"
```


## Values

- `"vector"`
- `"graph"`
