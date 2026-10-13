# EmbeddingModelListResponse

Response containing available embedding models and their limits

## Example Usage

```typescript
import { EmbeddingModelListResponse } from "@meetkai/mka1/models/components";

let value: EmbeddingModelListResponse = {
  data: [
    {
      id: "<id>",
      provider: "<value>",
      model: "Explorer",
      limits: {
        maxBatchSize: 2004.02,
        maxInputTokens: 6030.97,
        maxInputLength: 13.36,
      },
    },
  ],
};
```

## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `object`                                                                 | *"list"*                                                                 | :heavy_minus_sign:                                                       | N/A                                                                      |
| `data`                                                                   | [components.EmbeddingModel](../../models/components/embeddingmodel.md)[] | :heavy_check_mark:                                                       | List of available embedding models with their limits                     |