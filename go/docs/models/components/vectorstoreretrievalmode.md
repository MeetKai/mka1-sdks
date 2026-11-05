# VectorStoreRetrievalMode

Retrieval mode, frozen at creation. 'hybrid' (the default for new stores): vector similarity and full-text keyword search over the chunk text, fused by reciprocal rank fusion. 'vector': vector similarity search only. 'graph': GraphRAG — entities and relations are extracted at ingest and queries traverse the knowledge graph.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.VectorStoreRetrievalModeVector

// Open enum: custom values can be created with a direct type cast
custom := components.VectorStoreRetrievalMode("custom_value")
```


## Values

| Name                             | Value                            |
| -------------------------------- | -------------------------------- |
| `VectorStoreRetrievalModeVector` | vector                           |
| `VectorStoreRetrievalModeHybrid` | hybrid                           |
| `VectorStoreRetrievalModeGraph`  | graph                            |