# ResponseShellCallInProgressEvent

## Example Usage

```typescript
import { ResponseShellCallInProgressEvent } from "@meetkai/mka1/models/components";

let value: ResponseShellCallInProgressEvent = {
  type: "response.shell_call.in_progress",
  sequenceNumber: 750715,
  itemId: "<id>",
  outputIndex: 691989,
};
```

## Fields

| Field                                                                                                              | Type                                                                                                               | Required                                                                                                           | Description                                                                                                        |
| ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ |
| `type`                                                                                                             | *"response.shell_call.in_progress"*                                                                                | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |
| `sequenceNumber`                                                                                                   | *number*                                                                                                           | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |
| `itemId`                                                                                                           | *string*                                                                                                           | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |
| `outputIndex`                                                                                                      | *number*                                                                                                           | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |
| `args`                                                                                                             | [components.ResponseShellCallInProgressEventArgs](../../models/components/responseshellcallinprogresseventargs.md) | :heavy_minus_sign:                                                                                                 | N/A                                                                                                                |