# MCPToolCallWithId

MCP call item: A direct call record for an MCP tool, including request arguments and optional output/error.

## Example Usage

```typescript
import { MCPToolCallWithId } from "@meetkai/mka1/models/components";

let value: MCPToolCallWithId = {
  type: "mcp_call",
  id: "<id>",
  arguments: "<value>",
  name: "<value>",
  serverLabel: "<value>",
};
```

## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `type`                                                     | *"mcp_call"*                                               | :heavy_check_mark:                                         | N/A                                                        |
| `id`                                                       | *string*                                                   | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `approvalRequestId`                                        | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `arguments`                                                | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `name`                                                     | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `serverLabel`                                              | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `error`                                                    | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `output`                                                   | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `responseId`                                               | *string*                                                   | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `metadata`                                                 | Record<string, *string*>                                   | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |