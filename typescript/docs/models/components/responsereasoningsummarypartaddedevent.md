# ResponseReasoningSummaryPartAddedEvent

## Example Usage

```typescript
import { ResponseReasoningSummaryPartAddedEvent } from "@meetkai/mka1/models/components";

let value: ResponseReasoningSummaryPartAddedEvent = {
  type: "response.reasoning_summary_part.added",
  sequenceNumber: 309396,
  itemId: "<id>",
  outputIndex: 963314,
  summaryIndex: 807635,
  part: {
    type: "summary_text",
    text: "<value>",
  },
};
```

## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `type`                                                           | *"response.reasoning_summary_part.added"*                        | :heavy_check_mark:                                               | N/A                                                              |
| `sequenceNumber`                                                 | *number*                                                         | :heavy_check_mark:                                               | N/A                                                              |
| `itemId`                                                         | *string*                                                         | :heavy_check_mark:                                               | N/A                                                              |
| `outputIndex`                                                    | *number*                                                         | :heavy_check_mark:                                               | N/A                                                              |
| `summaryIndex`                                                   | *number*                                                         | :heavy_check_mark:                                               | N/A                                                              |
| `part`                                                           | [components.SummaryText](../../models/components/summarytext.md) | :heavy_check_mark:                                               | N/A                                                              |