# ResponseReasoningTextDoneEvent

## Example Usage

```typescript
import { ResponseReasoningTextDoneEvent } from "@meetkai/mka1/models/components";

let value: ResponseReasoningTextDoneEvent = {
  type: "response.reasoning_text.done",
  sequenceNumber: 37603,
  itemId: "<id>",
  outputIndex: 929665,
  contentIndex: 863259,
  text: "<value>",
};
```

## Fields

| Field                            | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `type`                           | *"response.reasoning_text.done"* | :heavy_check_mark:               | N/A                              |
| `sequenceNumber`                 | *number*                         | :heavy_check_mark:               | N/A                              |
| `itemId`                         | *string*                         | :heavy_check_mark:               | N/A                              |
| `outputIndex`                    | *number*                         | :heavy_check_mark:               | N/A                              |
| `contentIndex`                   | *number*                         | :heavy_check_mark:               | N/A                              |
| `text`                           | *string*                         | :heavy_check_mark:               | N/A                              |