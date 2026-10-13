# MCPListToolsWithId

MCP list tools item: Result of discovering available tools from an MCP server.

## Example Usage

```typescript
import { MCPListToolsWithId } from "@meetkai/mka1/models/components";

let value: MCPListToolsWithId = {
  type: "mcp_list_tools",
  id: "<id>",
  serverLabel: "<value>",
  tools: [],
};
```

## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `type`                                                     | *"mcp_list_tools"*                                         | :heavy_check_mark:                                         | N/A                                                        |
| `id`                                                       | *string*                                                   | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `serverLabel`                                              | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `tools`                                                    | [components.MCPTool](../../models/components/mcptool.md)[] | :heavy_check_mark:                                         | N/A                                                        |
| `error`                                                    | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `responseId`                                               | *string*                                                   | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `metadata`                                                 | Record<string, *string*>                                   | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |