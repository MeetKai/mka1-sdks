# EmbeddingsResponse

Response from the embeddings endpoint containing the generated embeddings and usage information.

## Example Usage

```typescript
import { EmbeddingsResponse } from "@meetkai/mka1/models/components";

let value: EmbeddingsResponse = {
  data: [
    {
      embedding: [
        0.0023,
        -0.0091,
        0.0156,
        -0.0042,
        0.0089,
      ],
      index: 0,
    },
  ],
  model: "auto",
  usage: {
    promptTokens: 8,
    totalTokens: 8,
  },
};
```

## Fields

| Field                                                                                                                                                                                      | Type                                                                                                                                                                                       | Required                                                                                                                                                                                   | Description                                                                                                                                                                                |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `data`                                                                                                                                                                                     | [components.Data](../../models/components/data.md)[]                                                                                                                                       | :heavy_check_mark:                                                                                                                                                                         | A list of embedding objects. Each object contains the embedding vector as an array of floating point numbers or base64-encoded string representing the semantic meaning of the input text. |
| `model`                                                                                                                                                                                    | *string*                                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                         | The model used for generating the embeddings                                                                                                                                               |
| `object`                                                                                                                                                                                   | *"list"*                                                                                                                                                                                   | :heavy_minus_sign:                                                                                                                                                                         | N/A                                                                                                                                                                                        |
| `usage`                                                                                                                                                                                    | [components.EmbeddingsResponseUsage](../../models/components/embeddingsresponseusage.md)                                                                                                   | :heavy_minus_sign:                                                                                                                                                                         | Usage statistics for the embeddings request                                                                                                                                                |