# LogProb

## Example Usage

```typescript
import { LogProb } from "@meetkai/mka1/models/components";

let value: LogProb = {
  token: "<value>",
  logprob: 3059.05,
  bytes: [],
  topLogprobs: [],
};
```

## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `token`                                                          | *string*                                                         | :heavy_check_mark:                                               | N/A                                                              |
| `logprob`                                                        | *number*                                                         | :heavy_check_mark:                                               | N/A                                                              |
| `bytes`                                                          | *number*[]                                                       | :heavy_check_mark:                                               | N/A                                                              |
| `topLogprobs`                                                    | [components.TopLogProb](../../models/components/toplogprob.md)[] | :heavy_check_mark:                                               | N/A                                                              |