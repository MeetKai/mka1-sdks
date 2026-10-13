# ResponseReasoningSummaryTextDoneEvent

## Example Usage

```typescript
import { ResponseReasoningSummaryTextDoneEvent } from "@meetkai/mka1/models/components";

let value: ResponseReasoningSummaryTextDoneEvent = {
  type: "response.reasoning_summary_text.done",
  sequenceNumber: 206223,
  itemId: "<id>",
  outputIndex: 366329,
  summaryIndex: 314125,
  text: "<value>",
};
```

## Fields

| Field                                    | Type                                     | Required                                 | Description                              |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| `type`                                   | *"response.reasoning_summary_text.done"* | :heavy_check_mark:                       | N/A                                      |
| `sequenceNumber`                         | *number*                                 | :heavy_check_mark:                       | N/A                                      |
| `itemId`                                 | *string*                                 | :heavy_check_mark:                       | N/A                                      |
| `outputIndex`                            | *number*                                 | :heavy_check_mark:                       | N/A                                      |
| `summaryIndex`                           | *number*                                 | :heavy_check_mark:                       | N/A                                      |
| `text`                                   | *string*                                 | :heavy_check_mark:                       | N/A                                      |