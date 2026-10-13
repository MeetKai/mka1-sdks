# ResponseReasoningTextDeltaEvent

## Example Usage

```typescript
import { ResponseReasoningTextDeltaEvent } from "@meetkai/mka1/models/components";

let value: ResponseReasoningTextDeltaEvent = {
  type: "response.reasoning_text.delta",
  sequenceNumber: 391800,
  itemId: "<id>",
  outputIndex: 467717,
  contentIndex: 357723,
  delta: "<value>",
};
```

## Fields

| Field                             | Type                              | Required                          | Description                       |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `type`                            | *"response.reasoning_text.delta"* | :heavy_check_mark:                | N/A                               |
| `sequenceNumber`                  | *number*                          | :heavy_check_mark:                | N/A                               |
| `itemId`                          | *string*                          | :heavy_check_mark:                | N/A                               |
| `outputIndex`                     | *number*                          | :heavy_check_mark:                | N/A                               |
| `contentIndex`                    | *number*                          | :heavy_check_mark:                | N/A                               |
| `delta`                           | *string*                          | :heavy_check_mark:                | N/A                               |