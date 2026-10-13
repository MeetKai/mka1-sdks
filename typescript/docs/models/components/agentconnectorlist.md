# AgentConnectorList

## Example Usage

```typescript
import { AgentConnectorList } from "@meetkai/mka1/models/components";

let value: AgentConnectorList = {
  object: "list",
  data: [
    {
      object: "agent.connector",
      id: "<id>",
      agentId: "<id>",
      provider: "telegram",
      name: "<value>",
      status: "<value>",
      providerAccountId: "<id>",
      providerAccountName: null,
      config: "<value>",
      credentialsConfigured: true,
      lastError: "<value>",
      createdAt: new Date("2026-10-20T00:29:59.608Z"),
      updatedAt: new Date("2026-11-14T13:44:26.753Z"),
      deletedAt: null,
    },
  ],
  firstId: "<id>",
  lastId: "<id>",
  hasMore: true,
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `object`                                                                                   | [components.AgentConnectorListObject](../../models/components/agentconnectorlistobject.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `data`                                                                                     | [components.AgentConnector](../../models/components/agentconnector.md)[]                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `firstId`                                                                                  | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `lastId`                                                                                   | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `hasMore`                                                                                  | *boolean*                                                                                  | :heavy_check_mark:                                                                         | N/A                                                                                        |