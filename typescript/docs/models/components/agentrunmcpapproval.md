# AgentRunMcpApproval

## Example Usage

```typescript
import { AgentRunMcpApproval } from "@meetkai/mka1/models/components";

let value: AgentRunMcpApproval = {
  object: "agent.run.mcp_approval",
  approvalRequestId: "<id>",
  approved: true,
  sourceRunId: "<id>",
  continuationRun: {
    object: "agent.run",
    id: "<id>",
    agentId: "<id>",
    agentVersion: null,
    status: "completed",
    input: "<value>",
    conversation: "<value>",
    previousResponseId: "<id>",
    metadata: null,
    gatewayResponseId: "<id>",
    gatewayResponse: "<value>",
    error: "<value>",
    createdAt: new Date("2026-11-27T05:08:54.135Z"),
    completedAt: new Date("2026-10-01T00:04:20.503Z"),
  },
};
```

## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `object`                                                                                     | [components.AgentRunMcpApprovalObject](../../models/components/agentrunmcpapprovalobject.md) | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `approvalRequestId`                                                                          | *string*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `approved`                                                                                   | *boolean*                                                                                    | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `sourceRunId`                                                                                | *string*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `continuationRun`                                                                            | [components.AgentRun](../../models/components/agentrun.md)                                   | :heavy_check_mark:                                                                           | N/A                                                                                          |