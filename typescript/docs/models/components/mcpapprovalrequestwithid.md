# MCPApprovalRequestWithId

MCP approval request item: A request to approve or deny execution of an MCP tool call.

## Example Usage

```typescript
import { MCPApprovalRequestWithId } from "@meetkai/mka1/models/components";

let value: MCPApprovalRequestWithId = {
  type: "mcp_approval_request",
  id: "<id>",
  arguments: "<value>",
  name: "<value>",
  serverLabel: "<value>",
};
```

## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `type`                                                     | *"mcp_approval_request"*                                   | :heavy_check_mark:                                         | N/A                                                        |
| `id`                                                       | *string*                                                   | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `arguments`                                                | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `name`                                                     | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `serverLabel`                                              | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `responseId`                                               | *string*                                                   | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `metadata`                                                 | Record<string, *string*>                                   | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |