# CreateVectorStoreRequestRetrievalMode

Retrieval mode, frozen at creation (cannot be changed later). 'hybrid' (default): vector similarity and full-text keyword search over the chunk text, fused by reciprocal rank fusion; the keyword index matches words in their written form in any language. 'vector': vector similarity search only. 'graph': GraphRAG — entities and relations are extracted from every chunk at ingest (metered against your usage) and search traverses the knowledge graph.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.CreateVectorStoreRequestRetrievalModeVector
```


## Values

| Name                                          | Value                                         |
| --------------------------------------------- | --------------------------------------------- |
| `CreateVectorStoreRequestRetrievalModeVector` | vector                                        |
| `CreateVectorStoreRequestRetrievalModeHybrid` | hybrid                                        |
| `CreateVectorStoreRequestRetrievalModeGraph`  | graph                                         |