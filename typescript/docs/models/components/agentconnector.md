# AgentConnector

## Example Usage

```typescript
import { AgentConnector } from "@meetkai/mka1/models/components";

let value: AgentConnector = {
  object: "agent.connector",
  id: "<id>",
  agentId: "<id>",
  provider: "telegram",
  name: "<value>",
  status: "<value>",
  providerAccountId: "<id>",
  providerAccountName: "<value>",
  config: "<value>",
  credentialsConfigured: false,
  lastError: "<value>",
  createdAt: new Date("2025-05-03T15:48:57.811Z"),
  updatedAt: new Date("2026-02-02T17:19:07.567Z"),
  deletedAt: new Date("2025-04-14T12:20:19.070Z"),
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `object`                                                                                      | [components.AgentConnectorObject](../../models/components/agentconnectorobject.md)            | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `id`                                                                                          | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `agentId`                                                                                     | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `provider`                                                                                    | [components.Provider](../../models/components/provider.md)                                    | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `name`                                                                                        | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `status`                                                                                      | *string*                                                                                      | :heavy_check_mark:                                                                            | Connector lifecycle status, such as provisioning, activating, active, deleting, or error.     |
| `providerAccountId`                                                                           | *string*                                                                                      | :heavy_check_mark:                                                                            | The provider account ID: Telegram bot user ID or WhatsApp phone-number ID.                    |
| `providerAccountName`                                                                         | *string*                                                                                      | :heavy_check_mark:                                                                            | Provider account display name when one is available.                                          |
| `config`                                                                                      | *any*                                                                                         | :heavy_check_mark:                                                                            | Arbitrary JSON value.                                                                         |
| `credentialsConfigured`                                                                       | *boolean*                                                                                     | :heavy_check_mark:                                                                            | Whether encrypted provider credentials are stored for this connector.                         |
| `lastError`                                                                                   | *any*                                                                                         | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `createdAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `updatedAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `deletedAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |