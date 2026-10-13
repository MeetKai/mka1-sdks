# ResponseRefusalDeltaEvent

## Example Usage

```typescript
import { ResponseRefusalDeltaEvent } from "@meetkai/mka1/models/components";

let value: ResponseRefusalDeltaEvent = {
  type: "response.refusal.delta",
  sequenceNumber: 395296,
  itemId: "<id>",
  outputIndex: 370708,
  contentIndex: 936011,
  delta: "<value>",
};
```

## Fields

| Field                      | Type                       | Required                   | Description                |
| -------------------------- | -------------------------- | -------------------------- | -------------------------- |
| `type`                     | *"response.refusal.delta"* | :heavy_check_mark:         | N/A                        |
| `sequenceNumber`           | *number*                   | :heavy_check_mark:         | N/A                        |
| `itemId`                   | *string*                   | :heavy_check_mark:         | N/A                        |
| `outputIndex`              | *number*                   | :heavy_check_mark:         | N/A                        |
| `contentIndex`             | *number*                   | :heavy_check_mark:         | N/A                        |
| `delta`                    | *string*                   | :heavy_check_mark:         | N/A                        |