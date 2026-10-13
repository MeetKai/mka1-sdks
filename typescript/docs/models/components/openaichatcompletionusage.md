# OpenAIChatCompletionUsage

Usage statistics for the completion request

## Example Usage

```typescript
import { OpenAIChatCompletionUsage } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionUsage = {
  promptTokens: 618625,
  completionTokens: 813414,
  totalTokens: 934750,
};
```

## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `promptTokens`                                                                           | *number*                                                                                 | :heavy_check_mark:                                                                       | Number of tokens in the prompt                                                           |
| `completionTokens`                                                                       | *number*                                                                                 | :heavy_check_mark:                                                                       | Number of tokens in the generated completion                                             |
| `totalTokens`                                                                            | *number*                                                                                 | :heavy_check_mark:                                                                       | Total number of tokens used in the request (prompt + completion)                         |
| `completionTokensDetails`                                                                | [components.CompletionTokensDetails](../../models/components/completiontokensdetails.md) | :heavy_minus_sign:                                                                       | Breakdown of completion tokens by type                                                   |