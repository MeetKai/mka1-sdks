# OpenAIChatCompletionChunkLogprobs

Log probability information for the choice

## Example Usage

```typescript
import { OpenAIChatCompletionChunkLogprobs } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionChunkLogprobs = {
  tokens: [
    "<value 1>",
    "<value 2>",
    "<value 3>",
  ],
  tokenLogprobs: [
    8300.07,
    1922.59,
  ],
  topLogprobs: [],
  textOffset: [],
};
```

## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `tokens`                                                                    | *string*[]                                                                  | :heavy_check_mark:                                                          | The list of tokens                                                          |
| `tokenLogprobs`                                                             | *number*[]                                                                  | :heavy_check_mark:                                                          | The log probability of each token                                           |
| `topLogprobs`                                                               | Record<string, *number*>[]                                                  | :heavy_check_mark:                                                          | The top log probabilities for each token position                           |
| `textOffset`                                                                | *number*[]                                                                  | :heavy_check_mark:                                                          | The character offset from the beginning of the returned text for each token |