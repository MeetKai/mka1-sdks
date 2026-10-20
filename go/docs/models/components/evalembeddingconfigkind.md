# EvalEmbeddingConfigKind

What the vectors are scored as. Decides the dataset layout the task expects and the metrics it reports.

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.EvalEmbeddingConfigKindSts
```


## Values

| Name                                              | Value                                             |
| ------------------------------------------------- | ------------------------------------------------- |
| `EvalEmbeddingConfigKindSts`                      | sts                                               |
| `EvalEmbeddingConfigKindClassification`           | classification                                    |
| `EvalEmbeddingConfigKindMultilabelClassification` | multilabel_classification                         |
| `EvalEmbeddingConfigKindRetrieval`                | retrieval                                         |
| `EvalEmbeddingConfigKindReranking`                | reranking                                         |