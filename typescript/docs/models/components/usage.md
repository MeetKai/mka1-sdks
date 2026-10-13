# Usage

## Example Usage

```typescript
import { Usage } from "@meetkai/mka1/models/components";

let value: Usage = {
  inputTokens: 979796,
  inputTokensDetails: {
    cachedTokens: 787440,
  },
  outputTokens: 860864,
  outputTokensDetails: {
    reasoningTokens: 470007,
  },
  totalTokens: 629232,
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `inputTokens`                                                                    | *number*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `inputTokensDetails`                                                             | [components.InputTokensDetails](../../models/components/inputtokensdetails.md)   | :heavy_check_mark:                                                               | N/A                                                                              |
| `outputTokens`                                                                   | *number*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `outputTokensDetails`                                                            | [components.OutputTokensDetails](../../models/components/outputtokensdetails.md) | :heavy_check_mark:                                                               | N/A                                                                              |
| `totalTokens`                                                                    | *number*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |