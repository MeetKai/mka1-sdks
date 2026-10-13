# ResponseSleepCallInProgressEvent

## Example Usage

```typescript
import { ResponseSleepCallInProgressEvent } from "@meetkai/mka1/models/components";

let value: ResponseSleepCallInProgressEvent = {
  type: "response.sleep_call.in_progress",
  sequenceNumber: 447892,
  itemId: "<id>",
  outputIndex: 116218,
};
```

## Fields

| Field                                                                                                              | Type                                                                                                               | Required                                                                                                           | Description                                                                                                        |
| ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ |
| `type`                                                                                                             | *"response.sleep_call.in_progress"*                                                                                | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |
| `sequenceNumber`                                                                                                   | *number*                                                                                                           | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |
| `itemId`                                                                                                           | *string*                                                                                                           | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |
| `outputIndex`                                                                                                      | *number*                                                                                                           | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |
| `args`                                                                                                             | [components.ResponseSleepCallInProgressEventArgs](../../models/components/responsesleepcallinprogresseventargs.md) | :heavy_minus_sign:                                                                                                 | N/A                                                                                                                |