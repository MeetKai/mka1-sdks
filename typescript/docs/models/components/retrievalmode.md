# RetrievalMode

Retrieval mode, frozen at creation (cannot be changed later). 'vector' (default): standard vector similarity search. 'graph': GraphRAG — entities and relations are extracted from every chunk at ingest (metered against your usage) and search traverses the knowledge graph.

## Example Usage

```typescript
import { RetrievalMode } from "@meetkai/mka1/models/components";

let value: RetrievalMode = "vector";
```

## Values

```typescript
"vector" | "graph"
```