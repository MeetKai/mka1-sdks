# ResponseShellCallCompletedEvent

## Example Usage

```typescript
import { ResponseShellCallCompletedEvent } from "@meetkai/mka1/models/components";

let value: ResponseShellCallCompletedEvent = {
  type: "response.shell_call.completed",
  sequenceNumber: 384317,
  itemId: "<id>",
  outputIndex: 879974,
};
```

## Fields

| Field                             | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `type`                            | *"response.shell_call.completed"* | :heavy_check_mark:                | N/A                               |
| `sequenceNumber`                  | *number*                          | :heavy_check_mark:                | N/A                               |
| `itemId`                          | *string*                          | :heavy_check_mark:                | N/A                               |
| `outputIndex`                     | *number*                          | :heavy_check_mark:                | N/A                               |
| `functionCallOutput`              | *string*                          | :heavy_minus_sign:                | N/A                               |