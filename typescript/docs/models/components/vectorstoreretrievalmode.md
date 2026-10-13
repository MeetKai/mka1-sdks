# VectorStoreRetrievalMode

Retrieval mode, frozen at creation. 'vector': standard vector similarity search. 'graph': GraphRAG — entities and relations are extracted at ingest and queries traverse the knowledge graph. 'hybrid' is reserved.

## Example Usage

```typescript
import { VectorStoreRetrievalMode } from "@meetkai/mka1/models/components";

let value: VectorStoreRetrievalMode = "hybrid";
```

## Values

```typescript
"vector" | "hybrid" | "graph"
```