# CustomToolCallOutputWithId

Custom tool call output item: The output payload returned by a custom tool call.

## Example Usage

```typescript
import { CustomToolCallOutputWithId } from "@meetkai/mka1/models/components";

let value: CustomToolCallOutputWithId = {
  type: "custom_tool_call_output",
  callId: "<id>",
  output: "<value>",
  id: "<id>",
};
```

## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `type`                                                     | *"custom_tool_call_output"*                                | :heavy_check_mark:                                         | N/A                                                        |
| `callId`                                                   | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `output`                                                   | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `id`                                                       | *string*                                                   | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `responseId`                                               | *string*                                                   | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `metadata`                                                 | Record<string, *string*>                                   | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |