# MCPApprovalResponse

MCP approval response item: The decision payload for a prior MCP approval request.

## Example Usage

```typescript
import { MCPApprovalResponse } from "@meetkai/mka1/models/components";

let value: MCPApprovalResponse = {
  type: "mcp_approval_response",
  approvalRequestId: "<id>",
  approve: true,
};
```

## Fields

| Field                     | Type                      | Required                  | Description               |
| ------------------------- | ------------------------- | ------------------------- | ------------------------- |
| `type`                    | *"mcp_approval_response"* | :heavy_check_mark:        | N/A                       |
| `approvalRequestId`       | *string*                  | :heavy_check_mark:        | N/A                       |
| `approve`                 | *boolean*                 | :heavy_check_mark:        | N/A                       |
| `id`                      | *string*                  | :heavy_minus_sign:        | N/A                       |
| `reason`                  | *string*                  | :heavy_minus_sign:        | N/A                       |