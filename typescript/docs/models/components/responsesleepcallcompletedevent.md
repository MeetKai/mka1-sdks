# ResponseSleepCallCompletedEvent

## Example Usage

```typescript
import { ResponseSleepCallCompletedEvent } from "@meetkai/mka1/models/components";

let value: ResponseSleepCallCompletedEvent = {
  type: "response.sleep_call.completed",
  sequenceNumber: 285309,
  itemId: "<id>",
  outputIndex: 255102,
};
```

## Fields

| Field                                                                                                                | Type                                                                                                                 | Required                                                                                                             | Description                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- |
| `type`                                                                                                               | *"response.sleep_call.completed"*                                                                                    | :heavy_check_mark:                                                                                                   | N/A                                                                                                                  |
| `sequenceNumber`                                                                                                     | *number*                                                                                                             | :heavy_check_mark:                                                                                                   | N/A                                                                                                                  |
| `itemId`                                                                                                             | *string*                                                                                                             | :heavy_check_mark:                                                                                                   | N/A                                                                                                                  |
| `outputIndex`                                                                                                        | *number*                                                                                                             | :heavy_check_mark:                                                                                                   | N/A                                                                                                                  |
| `functionCallOutput`                                                                                                 | *string*                                                                                                             | :heavy_minus_sign:                                                                                                   | N/A                                                                                                                  |
| `status`                                                                                                             | [components.ResponseSleepCallCompletedEventStatus](../../models/components/responsesleepcallcompletedeventstatus.md) | :heavy_minus_sign:                                                                                                   | N/A                                                                                                                  |