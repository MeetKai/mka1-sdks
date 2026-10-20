# CreateVectorStoreRequestRetrievalMode

Retrieval mode, frozen at creation (cannot be changed later). 'vector' (default): standard vector similarity search. 'graph': GraphRAG — entities and relations are extracted from every chunk at ingest (metered against your usage) and search traverses the knowledge graph.

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
| `CreateVectorStoreRequestRetrievalModeGraph`  | graph                                         |