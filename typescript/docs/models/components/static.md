# Static

## Example Usage

```typescript
import { Static } from "@meetkai/mka1/models/components";

let value: Static = {
  chunkOverlapTokens: 63359,
  maxChunkSizeTokens: 961675,
};
```

## Fields

| Field                                                                                                                         | Type                                                                                                                          | Required                                                                                                                      | Description                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| `chunkOverlapTokens`                                                                                                          | *number*                                                                                                                      | :heavy_check_mark:                                                                                                            | The number of tokens that overlap between chunks. The default value is 400. Must not exceed half of max_chunk_size_tokens.    |
| `maxChunkSizeTokens`                                                                                                          | *number*                                                                                                                      | :heavy_check_mark:                                                                                                            | The maximum number of tokens in each chunk. The default value is 800. The minimum value is 100 and the maximum value is 4096. |