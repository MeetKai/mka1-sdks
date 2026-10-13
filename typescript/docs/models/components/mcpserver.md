# McpServer

## Example Usage

```typescript
import { McpServer } from "@meetkai/mka1/models/components";

let value: McpServer = {
  id: "<id>",
  object: "mcp.server",
  name: "<value>",
  serverLabel: "<value>",
  serverUrl: "https://polished-swing.com/",
  serverDescription: "<value>",
  allowedTools: [],
  requireApproval: "always",
  metadata: {
    "key": "<value>",
  },
  createdAt: new Date("2025-09-01T05:23:31.935Z"),
  updatedAt: new Date("2026-12-03T11:47:52.446Z"),
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `id`                                                                                          | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `object`                                                                                      | *"mcp.server"*                                                                                | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `name`                                                                                        | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `serverLabel`                                                                                 | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `serverUrl`                                                                                   | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `serverDescription`                                                                           | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `allowedTools`                                                                                | *components.MCPAllowedTools*                                                                  | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `requireApproval`                                                                             | [components.MCPRequireApproval](../../models/components/mcprequireapproval.md)                | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `metadata`                                                                                    | Record<string, *any*>                                                                         | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `createdAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `updatedAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |