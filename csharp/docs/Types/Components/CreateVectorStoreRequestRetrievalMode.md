# CreateVectorStoreRequestRetrievalMode

Retrieval mode, frozen at creation (cannot be changed later). 'vector' (default): standard vector similarity search. 'graph': GraphRAG — entities and relations are extracted from every chunk at ingest (metered against your usage) and search traverses the knowledge graph.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = CreateVectorStoreRequestRetrievalMode.Vector;
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Vector` | vector   |
| `Graph`  | graph    |