# ResponseCustomToolCallInputDeltaEvent

## Example Usage

```typescript
import { ResponseCustomToolCallInputDeltaEvent } from "@meetkai/mka1/models/components";

let value: ResponseCustomToolCallInputDeltaEvent = {
  type: "response.custom_tool_call_input.delta",
  sequenceNumber: 591313,
  itemId: "<id>",
  outputIndex: 597994,
  delta: "<value>",
};
```

## Fields

| Field                                     | Type                                      | Required                                  | Description                               |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| `type`                                    | *"response.custom_tool_call_input.delta"* | :heavy_check_mark:                        | N/A                                       |
| `sequenceNumber`                          | *number*                                  | :heavy_check_mark:                        | N/A                                       |
| `itemId`                                  | *string*                                  | :heavy_check_mark:                        | N/A                                       |
| `outputIndex`                             | *number*                                  | :heavy_check_mark:                        | N/A                                       |
| `delta`                                   | *string*                                  | :heavy_check_mark:                        | N/A                                       |