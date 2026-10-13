# Kind

What the vectors are scored as. Decides the dataset layout the task expects and the metrics it reports.

## Example Usage

```typescript
import { Kind } from "@meetkai/mka1/models/components";

let value: Kind = "sts";
```

## Values

```typescript
"sts" | "classification" | "multilabel_classification" | "retrieval" | "reranking"
```