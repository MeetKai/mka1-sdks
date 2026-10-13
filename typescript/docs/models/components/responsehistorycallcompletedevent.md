# ResponseHistoryCallCompletedEvent

## Example Usage

```typescript
import { ResponseHistoryCallCompletedEvent } from "@meetkai/mka1/models/components";

let value: ResponseHistoryCallCompletedEvent = {
  type: "response.history_call.completed",
  sequenceNumber: 987348,
  itemId: "<id>",
  outputIndex: 710280,
};
```

## Fields

| Field                               | Type                                | Required                            | Description                         |
| ----------------------------------- | ----------------------------------- | ----------------------------------- | ----------------------------------- |
| `type`                              | *"response.history_call.completed"* | :heavy_check_mark:                  | N/A                                 |
| `sequenceNumber`                    | *number*                            | :heavy_check_mark:                  | N/A                                 |
| `itemId`                            | *string*                            | :heavy_check_mark:                  | N/A                                 |
| `outputIndex`                       | *number*                            | :heavy_check_mark:                  | N/A                                 |
| `functionCallOutput`                | *string*                            | :heavy_minus_sign:                  | N/A                                 |