# AgentRunList

## Example Usage

```typescript
import { AgentRunList } from "@meetkai/mka1/models/components";

let value: AgentRunList = {
  object: "list",
  data: [
    {
      object: "agent.run",
      id: "<id>",
      agentId: "<id>",
      agentVersion: 397124,
      status: "submitting",
      input: "<value>",
      conversation: "<value>",
      previousResponseId: null,
      metadata: {
        "key": "<value>",
        "key1": "<value>",
      },
      gatewayResponseId: "<id>",
      gatewayResponse: "<value>",
      error: "<value>",
      createdAt: new Date("2026-08-06T03:25:18.279Z"),
      completedAt: new Date("2025-09-04T05:13:51.025Z"),
    },
  ],
  firstId: "<id>",
  lastId: "<id>",
  hasMore: false,
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `object`                                                                       | [components.AgentRunListObject](../../models/components/agentrunlistobject.md) | :heavy_check_mark:                                                             | N/A                                                                            |
| `data`                                                                         | [components.AgentRun](../../models/components/agentrun.md)[]                   | :heavy_check_mark:                                                             | N/A                                                                            |
| `firstId`                                                                      | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `lastId`                                                                       | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `hasMore`                                                                      | *boolean*                                                                      | :heavy_check_mark:                                                             | N/A                                                                            |