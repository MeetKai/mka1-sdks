# Logprobs

Log probability information for the choice

## Example Usage

```typescript
import { Logprobs } from "@meetkai/mka1/models/components";

let value: Logprobs = {
  tokens: [
    "<value 1>",
    "<value 2>",
  ],
  tokenLogprobs: [],
  topLogprobs: [
    {},
    {},
    {
      "key": 2166.78,
    },
  ],
  textOffset: [
    495432,
  ],
};
```

## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `tokens`                                                                    | *string*[]                                                                  | :heavy_check_mark:                                                          | The list of tokens                                                          |
| `tokenLogprobs`                                                             | *number*[]                                                                  | :heavy_check_mark:                                                          | The log probability of each token                                           |
| `topLogprobs`                                                               | Record<string, *number*>[]                                                  | :heavy_check_mark:                                                          | The top log probabilities for each token position                           |
| `textOffset`                                                                | *number*[]                                                                  | :heavy_check_mark:                                                          | The character offset from the beginning of the returned text for each token |