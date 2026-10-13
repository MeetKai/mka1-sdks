# ResponseRefusalDoneEvent

## Example Usage

```typescript
import { ResponseRefusalDoneEvent } from "@meetkai/mka1/models/components";

let value: ResponseRefusalDoneEvent = {
  type: "response.refusal.done",
  sequenceNumber: 304504,
  itemId: "<id>",
  outputIndex: 425869,
  contentIndex: 108305,
  refusal: "<value>",
};
```

## Fields

| Field                     | Type                      | Required                  | Description               |
| ------------------------- | ------------------------- | ------------------------- | ------------------------- |
| `type`                    | *"response.refusal.done"* | :heavy_check_mark:        | N/A                       |
| `sequenceNumber`          | *number*                  | :heavy_check_mark:        | N/A                       |
| `itemId`                  | *string*                  | :heavy_check_mark:        | N/A                       |
| `outputIndex`             | *number*                  | :heavy_check_mark:        | N/A                       |
| `contentIndex`            | *number*                  | :heavy_check_mark:        | N/A                       |
| `refusal`                 | *string*                  | :heavy_check_mark:        | N/A                       |