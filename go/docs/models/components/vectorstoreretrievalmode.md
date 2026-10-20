# VectorStoreRetrievalMode

Retrieval mode, frozen at creation. 'vector': standard vector similarity search. 'graph': GraphRAG — entities and relations are extracted at ingest and queries traverse the knowledge graph. 'hybrid' is reserved.

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