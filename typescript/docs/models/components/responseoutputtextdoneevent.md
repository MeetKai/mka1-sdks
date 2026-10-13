# ResponseOutputTextDoneEvent

## Example Usage

```typescript
import { ResponseOutputTextDoneEvent } from "@meetkai/mka1/models/components";

let value: ResponseOutputTextDoneEvent = {
  type: "response.output_text.done",
  sequenceNumber: 425179,
  itemId: "<id>",
  outputIndex: 633225,
  contentIndex: 237429,
  text: "<value>",
};
```

## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `type`                                                               | *"response.output_text.done"*                                        | :heavy_check_mark:                                                   | N/A                                                                  |
| `sequenceNumber`                                                     | *number*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `itemId`                                                             | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `outputIndex`                                                        | *number*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `contentIndex`                                                       | *number*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `text`                                                               | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `logprobs`                                                           | [components.LogProbToken](../../models/components/logprobtoken.md)[] | :heavy_minus_sign:                                                   | N/A                                                                  |