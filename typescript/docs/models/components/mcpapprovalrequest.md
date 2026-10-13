# MCPApprovalRequest

MCP approval request item: A request to approve or deny execution of an MCP tool call.

## Example Usage

```typescript
import { MCPApprovalRequest } from "@meetkai/mka1/models/components";

let value: MCPApprovalRequest = {
  type: "mcp_approval_request",
  id: "<id>",
  arguments: "<value>",
  name: "<value>",
  serverLabel: "<value>",
};
```

## Fields

| Field                    | Type                     | Required                 | Description              |
| ------------------------ | ------------------------ | ------------------------ | ------------------------ |
| `type`                   | *"mcp_approval_request"* | :heavy_check_mark:       | N/A                      |
| `id`                     | *string*                 | :heavy_check_mark:       | N/A                      |
| `arguments`              | *string*                 | :heavy_check_mark:       | N/A                      |
| `name`                   | *string*                 | :heavy_check_mark:       | N/A                      |
| `serverLabel`            | *string*                 | :heavy_check_mark:       | N/A                      |