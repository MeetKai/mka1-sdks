# EvalEmbeddingConfigKind

What the vectors are scored as. Decides the dataset layout the task expects and the metrics it reports.

## Example Usage

```python
from meetkai_mka1.models import EvalEmbeddingConfigKind
value: EvalEmbeddingConfigKind = "sts"
```


## Values

- `"sts"`
- `"classification"`
- `"multilabel_classification"`
- `"retrieval"`
- `"reranking"`
