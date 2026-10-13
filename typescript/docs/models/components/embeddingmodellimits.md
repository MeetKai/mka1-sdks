# EmbeddingModelLimits

Limits for the embedding model

## Example Usage

```typescript
import { EmbeddingModelLimits } from "@meetkai/mka1/models/components";

let value: EmbeddingModelLimits = {
  maxBatchSize: 6701.34,
  maxInputTokens: 3822.16,
  maxInputLength: 8250.53,
};
```

## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `maxBatchSize`                                                   | *number*                                                         | :heavy_check_mark:                                               | Maximum number of inputs allowed in a single batch request       |
| `maxInputTokens`                                                 | *number*                                                         | :heavy_check_mark:                                               | Maximum tokens per individual input (derived from contextWindow) |
| `maxInputLength`                                                 | *number*                                                         | :heavy_check_mark:                                               | Maximum characters per individual input (contextWindow * 2)      |