# OpenAIChatCompletionUsage1

Usage statistics for the completion request

## Example Usage

```typescript
import { OpenAIChatCompletionUsage1 } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionUsage1 = {
  promptTokens: 301373,
  completionTokens: 277334,
  totalTokens: 484312,
};
```

## Fields

| Field                                                                                                                            | Type                                                                                                                             | Required                                                                                                                         | Description                                                                                                                      |
| -------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------- |
| `promptTokens`                                                                                                                   | *number*                                                                                                                         | :heavy_check_mark:                                                                                                               | Number of tokens in the prompt                                                                                                   |
| `completionTokens`                                                                                                               | *number*                                                                                                                         | :heavy_check_mark:                                                                                                               | Number of tokens in the generated completion                                                                                     |
| `totalTokens`                                                                                                                    | *number*                                                                                                                         | :heavy_check_mark:                                                                                                               | Total number of tokens used in the request (prompt + completion)                                                                 |
| `completionTokensDetails`                                                                                                        | [components.OpenAIChatCompletionCompletionTokensDetails](../../models/components/openaichatcompletioncompletiontokensdetails.md) | :heavy_minus_sign:                                                                                                               | Breakdown of completion tokens by type                                                                                           |