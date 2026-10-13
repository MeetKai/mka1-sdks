# DecideAgentRunMcpApprovalRequest

## Example Usage

```typescript
import { DecideAgentRunMcpApprovalRequest } from "@meetkai/mka1/models/operations";

let value: DecideAgentRunMcpApprovalRequest = {
  agentId: "<id>",
  runId: "<id>",
  decideAgentRunMcpApprovalRequest: {
    approvalRequestId: "<id>",
    approve: false,
  },
};
```

## Fields

| Field                                                                                                      | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `agentId`                                                                                                  | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `runId`                                                                                                    | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `xOnBehalfOf`                                                                                              | *string*                                                                                                   | :heavy_minus_sign:                                                                                         | Optional external end-user identifier forwarded by the API gateway.                                        |
| `decideAgentRunMcpApprovalRequest`                                                                         | [components.DecideAgentRunMcpApprovalRequest](../../models/components/decideagentrunmcpapprovalrequest.md) | :heavy_check_mark:                                                                                         | N/A                                                                                                        |