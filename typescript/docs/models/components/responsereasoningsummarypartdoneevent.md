# ResponseReasoningSummaryPartDoneEvent

## Example Usage

```typescript
import { ResponseReasoningSummaryPartDoneEvent } from "@meetkai/mka1/models/components";

let value: ResponseReasoningSummaryPartDoneEvent = {
  type: "response.reasoning_summary_part.done",
  sequenceNumber: 623077,
  itemId: "<id>",
  outputIndex: 94231,
  summaryIndex: 500735,
  part: {
    type: "summary_text",
    text: "<value>",
  },
};
```

## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `type`                                                           | *"response.reasoning_summary_part.done"*                         | :heavy_check_mark:                                               | N/A                                                              |
| `sequenceNumber`                                                 | *number*                                                         | :heavy_check_mark:                                               | N/A                                                              |
| `itemId`                                                         | *string*                                                         | :heavy_check_mark:                                               | N/A                                                              |
| `outputIndex`                                                    | *number*                                                         | :heavy_check_mark:                                               | N/A                                                              |
| `summaryIndex`                                                   | *number*                                                         | :heavy_check_mark:                                               | N/A                                                              |
| `part`                                                           | [components.SummaryText](../../models/components/summarytext.md) | :heavy_check_mark:                                               | N/A                                                              |