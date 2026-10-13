# EmbedRequest

## Example Usage

```typescript
import { EmbedRequest } from "@meetkai/mka1/models/operations";

let value: EmbedRequest = {
  embeddingsRequest: {
    input: "The quick brown fox jumps over the lazy dog.",
    model: "auto",
  },
};
```

## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  | Example                                                                      |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                | *string*                                                                     | :heavy_minus_sign:                                                           | Optional external end-user identifier forwarded by the API gateway.          |                                                                              |
| `embeddingsRequest`                                                          | [components.EmbeddingsRequest](../../models/components/embeddingsrequest.md) | :heavy_check_mark:                                                           | N/A                                                                          | {<br/>"model": "auto",<br/>"input": "The quick brown fox jumps over the lazy dog."<br/>} |