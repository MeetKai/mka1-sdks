# CompactedResponse

## Example Usage

```typescript
import { CompactedResponse } from "@meetkai/mka1/models/components";

let value: CompactedResponse = {
  id: "<id>",
  createdAt: 583619,
  object: "response.compaction",
  output: [],
  usage: {
    inputTokens: 757988,
    inputTokensDetails: {
      cachedTokens: 787440,
    },
    outputTokens: 627914,
    outputTokensDetails: {
      reasoningTokens: 470007,
    },
    totalTokens: 360122,
  },
};
```

## Fields

| Field                                                | Type                                                 | Required                                             | Description                                          |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `id`                                                 | *string*                                             | :heavy_check_mark:                                   | N/A                                                  |
| `createdAt`                                          | *number*                                             | :heavy_check_mark:                                   | N/A                                                  |
| `object`                                             | *"response.compaction"*                              | :heavy_check_mark:                                   | N/A                                                  |
| `output`                                             | *components.Item*[]                                  | :heavy_check_mark:                                   | N/A                                                  |
| `usage`                                              | [components.Usage](../../models/components/usage.md) | :heavy_check_mark:                                   | N/A                                                  |