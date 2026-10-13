# MCPToolChoice

MCP tool choice: Forces an MCP server, optionally narrowed to a specific MCP tool name.

## Example Usage

```typescript
import { MCPToolChoice } from "@meetkai/mka1/models/components";

let value: MCPToolChoice = {
  type: "mcp",
  serverLabel: "<value>",
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `type`             | *"mcp"*            | :heavy_check_mark: | N/A                |
| `serverLabel`      | *string*           | :heavy_check_mark: | N/A                |
| `name`             | *string*           | :heavy_minus_sign: | N/A                |