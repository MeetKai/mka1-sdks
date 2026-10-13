# AgentRun

## Example Usage

```typescript
import { AgentRun } from "@meetkai/mka1/models/components";

let value: AgentRun = {
  object: "agent.run",
  id: "<id>",
  agentId: "<id>",
  agentVersion: 350685,
  status: "submitting",
  input: "<value>",
  conversation: "<value>",
  previousResponseId: "<id>",
  metadata: {},
  gatewayResponseId: "<id>",
  gatewayResponse: "<value>",
  error: "<value>",
  createdAt: new Date("2024-07-20T17:55:44.853Z"),
  completedAt: new Date("2024-05-11T22:06:28.971Z"),
};
```

## Fields

| Field                                                                                               | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `object`                                                                                            | [components.AgentRunObject](../../models/components/agentrunobject.md)                              | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `id`                                                                                                | *string*                                                                                            | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `agentId`                                                                                           | *string*                                                                                            | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `agentVersion`                                                                                      | *number*                                                                                            | :heavy_check_mark:                                                                                  | The agent configuration version this run executed against. Null for runs created before versioning. |
| `status`                                                                                            | [components.AgentRunStatus](../../models/components/agentrunstatus.md)                              | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `input`                                                                                             | *any*                                                                                               | :heavy_check_mark:                                                                                  | Arbitrary JSON value.                                                                               |
| `conversation`                                                                                      | *any*                                                                                               | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `previousResponseId`                                                                                | *string*                                                                                            | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `metadata`                                                                                          | Record<string, *string*>                                                                            | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `gatewayResponseId`                                                                                 | *string*                                                                                            | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `gatewayResponse`                                                                                   | *any*                                                                                               | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `error`                                                                                             | *any*                                                                                               | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `createdAt`                                                                                         | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)       | :heavy_check_mark:                                                                                  | N/A                                                                                                 |
| `completedAt`                                                                                       | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)       | :heavy_check_mark:                                                                                  | N/A                                                                                                 |