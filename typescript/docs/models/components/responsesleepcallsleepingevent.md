# ResponseSleepCallSleepingEvent

## Example Usage

```typescript
import { ResponseSleepCallSleepingEvent } from "@meetkai/mka1/models/components";

let value: ResponseSleepCallSleepingEvent = {
  type: "response.sleep_call.sleeping",
  sequenceNumber: 8071,
  itemId: "<id>",
  outputIndex: 627619,
};
```

## Fields

| Field                            | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `type`                           | *"response.sleep_call.sleeping"* | :heavy_check_mark:               | N/A                              |
| `sequenceNumber`                 | *number*                         | :heavy_check_mark:               | N/A                              |
| `itemId`                         | *string*                         | :heavy_check_mark:               | N/A                              |
| `outputIndex`                    | *number*                         | :heavy_check_mark:               | N/A                              |
| `wakeAt`                         | *string*                         | :heavy_minus_sign:               | N/A                              |