# MCPApprovalResponseWithId

MCP approval response item: The decision payload for a prior MCP approval request.

## Example Usage

```typescript
import { MCPApprovalResponseWithId } from "@meetkai/mka1/models/components";

let value: MCPApprovalResponseWithId = {
  type: "mcp_approval_response",
  approvalRequestId: "<id>",
  approve: false,
  id: "<id>",
};
```

## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `type`                                                     | *"mcp_approval_response"*                                  | :heavy_check_mark:                                         | N/A                                                        |
| `approvalRequestId`                                        | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `approve`                                                  | *boolean*                                                  | :heavy_check_mark:                                         | N/A                                                        |
| `id`                                                       | *string*                                                   | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `reason`                                                   | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `responseId`                                               | *string*                                                   | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `metadata`                                                 | Record<string, *string*>                                   | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |