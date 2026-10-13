# ResponseOutputTextDeltaEvent

## Example Usage

```typescript
import { ResponseOutputTextDeltaEvent } from "@meetkai/mka1/models/components";

let value: ResponseOutputTextDeltaEvent = {
  type: "response.output_text.delta",
  sequenceNumber: 673164,
  itemId: "<id>",
  outputIndex: 487856,
  contentIndex: 110262,
  delta: "<value>",
};
```

## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `type`                                                               | *"response.output_text.delta"*                                       | :heavy_check_mark:                                                   | N/A                                                                  |
| `sequenceNumber`                                                     | *number*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `itemId`                                                             | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `outputIndex`                                                        | *number*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `contentIndex`                                                       | *number*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `delta`                                                              | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `logprobs`                                                           | [components.LogProbToken](../../models/components/logprobtoken.md)[] | :heavy_minus_sign:                                                   | N/A                                                                  |