# ResponseHistoryCallInProgressEvent

## Example Usage

```typescript
import { ResponseHistoryCallInProgressEvent } from "@meetkai/mka1/models/components";

let value: ResponseHistoryCallInProgressEvent = {
  type: "response.history_call.in_progress",
  sequenceNumber: 197848,
  itemId: "<id>",
  outputIndex: 309237,
};
```

## Fields

| Field                                                                                                                  | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `type`                                                                                                                 | *"response.history_call.in_progress"*                                                                                  | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `sequenceNumber`                                                                                                       | *number*                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `itemId`                                                                                                               | *string*                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `outputIndex`                                                                                                          | *number*                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `args`                                                                                                                 | [components.ResponseHistoryCallInProgressEventArgs](../../models/components/responsehistorycallinprogresseventargs.md) | :heavy_minus_sign:                                                                                                     | N/A                                                                                                                    |