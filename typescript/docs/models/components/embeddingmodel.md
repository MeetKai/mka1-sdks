# EmbeddingModel

Information about an embedding model and its limits

## Example Usage

```typescript
import { EmbeddingModel } from "@meetkai/mka1/models/components";

let value: EmbeddingModel = {
  id: "<id>",
  provider: "<value>",
  model: "Land Cruiser",
  limits: {
    maxBatchSize: 2004.02,
    maxInputTokens: 6030.97,
    maxInputLength: 13.36,
  },
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `id`                                                                               | *string*                                                                           | :heavy_check_mark:                                                                 | Qualified model identifier in provider:model format                                |
| `provider`                                                                         | *string*                                                                           | :heavy_check_mark:                                                                 | Provider identifier (e.g., 'meetkai')                                              |
| `model`                                                                            | *string*                                                                           | :heavy_check_mark:                                                                 | Model identifier within the provider                                               |
| `limits`                                                                           | [components.EmbeddingModelLimits](../../models/components/embeddingmodellimits.md) | :heavy_check_mark:                                                                 | Limits for the embedding model                                                     |