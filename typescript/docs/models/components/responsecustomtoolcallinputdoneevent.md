# ResponseCustomToolCallInputDoneEvent

## Example Usage

```typescript
import { ResponseCustomToolCallInputDoneEvent } from "@meetkai/mka1/models/components";

let value: ResponseCustomToolCallInputDoneEvent = {
  type: "response.custom_tool_call_input.done",
  sequenceNumber: 202366,
  itemId: "<id>",
  outputIndex: 85806,
  input: "<value>",
};
```

## Fields

| Field                                    | Type                                     | Required                                 | Description                              |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| `type`                                   | *"response.custom_tool_call_input.done"* | :heavy_check_mark:                       | N/A                                      |
| `sequenceNumber`                         | *number*                                 | :heavy_check_mark:                       | N/A                                      |
| `itemId`                                 | *string*                                 | :heavy_check_mark:                       | N/A                                      |
| `outputIndex`                            | *number*                                 | :heavy_check_mark:                       | N/A                                      |
| `input`                                  | *string*                                 | :heavy_check_mark:                       | N/A                                      |