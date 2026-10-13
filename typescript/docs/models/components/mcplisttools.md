# MCPListTools

MCP list tools item: Result of discovering available tools from an MCP server.

## Example Usage

```typescript
import { MCPListTools } from "@meetkai/mka1/models/components";

let value: MCPListTools = {
  type: "mcp_list_tools",
  id: "<id>",
  serverLabel: "<value>",
  tools: [
    {
      name: "<value>",
      inputSchema: {
        "key": "<value>",
        "key1": "<value>",
      },
    },
  ],
};
```

## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `type`                                                     | *"mcp_list_tools"*                                         | :heavy_check_mark:                                         | N/A                                                        |
| `id`                                                       | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `serverLabel`                                              | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `tools`                                                    | [components.MCPTool](../../models/components/mcptool.md)[] | :heavy_check_mark:                                         | N/A                                                        |
| `error`                                                    | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |