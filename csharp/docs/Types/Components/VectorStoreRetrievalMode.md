# VectorStoreRetrievalMode

Retrieval mode, frozen at creation. 'vector': standard vector similarity search. 'graph': GraphRAG — entities and relations are extracted at ingest and queries traverse the knowledge graph. 'hybrid' is reserved.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = VectorStoreRetrievalMode.Vector;
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Vector` | vector   |
| `Hybrid` | hybrid   |
| `Graph`  | graph    |