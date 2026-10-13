# ResponseOutputItemDoneEvent

## Example Usage

```typescript
import { ResponseOutputItemDoneEvent } from "@meetkai/mka1/models/components";

let value: ResponseOutputItemDoneEvent = {
  type: "response.output_item.done",
  sequenceNumber: 525098,
  outputIndex: 63506,
  item: {
    type: "computer_call",
    id: "<id>",
    callId: "<id>",
    action: {
      type: "double_click",
      x: 992146,
      y: 991972,
    },
    pendingSafetyChecks: [],
    status: "completed",
  },
};
```

## Fields

| Field                         | Type                          | Required                      | Description                   |
| ----------------------------- | ----------------------------- | ----------------------------- | ----------------------------- |
| `type`                        | *"response.output_item.done"* | :heavy_check_mark:            | N/A                           |
| `sequenceNumber`              | *number*                      | :heavy_check_mark:            | N/A                           |
| `outputIndex`                 | *number*                      | :heavy_check_mark:            | N/A                           |
| `item`                        | *components.Item*             | :heavy_check_mark:            | N/A                           |