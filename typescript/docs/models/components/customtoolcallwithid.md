# CustomToolCallWithId

Custom tool call item: A call record for a custom tool with input payload and tool name.

## Example Usage

```typescript
import { CustomToolCallWithId } from "@meetkai/mka1/models/components";

let value: CustomToolCallWithId = {
  type: "custom_tool_call",
  callId: "<id>",
  input: "<value>",
  name: "<value>",
  id: "<id>",
};
```

## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `type`                                                     | *"custom_tool_call"*                                       | :heavy_check_mark:                                         | N/A                                                        |
| `callId`                                                   | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `input`                                                    | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `name`                                                     | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `id`                                                       | *string*                                                   | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `responseId`                                               | *string*                                                   | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `metadata`                                                 | Record<string, *string*>                                   | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |