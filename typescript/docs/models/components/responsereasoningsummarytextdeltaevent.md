# ResponseReasoningSummaryTextDeltaEvent

## Example Usage

```typescript
import { ResponseReasoningSummaryTextDeltaEvent } from "@meetkai/mka1/models/components";

let value: ResponseReasoningSummaryTextDeltaEvent = {
  type: "response.reasoning_summary_text.delta",
  sequenceNumber: 143710,
  itemId: "<id>",
  outputIndex: 391272,
  summaryIndex: 56099,
  delta: "<value>",
};
```

## Fields

| Field                                     | Type                                      | Required                                  | Description                               |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| `type`                                    | *"response.reasoning_summary_text.delta"* | :heavy_check_mark:                        | N/A                                       |
| `sequenceNumber`                          | *number*                                  | :heavy_check_mark:                        | N/A                                       |
| `itemId`                                  | *string*                                  | :heavy_check_mark:                        | N/A                                       |
| `outputIndex`                             | *number*                                  | :heavy_check_mark:                        | N/A                                       |
| `summaryIndex`                            | *number*                                  | :heavy_check_mark:                        | N/A                                       |
| `delta`                                   | *string*                                  | :heavy_check_mark:                        | N/A                                       |