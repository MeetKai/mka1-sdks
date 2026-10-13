# EvalEmbeddingConfigKind

What the vectors are scored as. Decides the dataset layout the task expects and the metrics it reports.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = EvalEmbeddingConfigKind.Sts;
```


## Values

| Name                       | Value                      |
| -------------------------- | -------------------------- |
| `Sts`                      | sts                        |
| `Classification`           | classification             |
| `MultilabelClassification` | multilabel_classification  |
| `Retrieval`                | retrieval                  |
| `Reranking`                | reranking                  |