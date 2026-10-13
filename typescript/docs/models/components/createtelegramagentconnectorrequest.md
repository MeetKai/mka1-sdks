# CreateTelegramAgentConnectorRequest

## Example Usage

```typescript
import { CreateTelegramAgentConnectorRequest } from "@meetkai/mka1/models/components";

let value: CreateTelegramAgentConnectorRequest = {
  provider: "telegram",
  credentials: {
    botToken: "<value>",
  },
  access: {
    mode: "allowlist",
    chatIds: [
      677576,
      162650,
      4067,
    ],
  },
};
```

## Fields

| Field                                                                                                                                                                            | Type                                                                                                                                                                             | Required                                                                                                                                                                         | Description                                                                                                                                                                      |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `provider`                                                                                                                                                                       | *"telegram"*                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                               | Telegram Bot API connector. Supports text, photos up to the Bot API's 20 MiB download limit, gateway-supported documents, and response feedback through native thumbs reactions. |
| `name`                                                                                                                                                                           | *string*                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                               | N/A                                                                                                                                                                              |
| `credentials`                                                                                                                                                                    | [components.Credentials](../../models/components/credentials.md)                                                                                                                 | :heavy_check_mark:                                                                                                                                                               | N/A                                                                                                                                                                              |
| `access`                                                                                                                                                                         | [components.CreateTelegramAgentConnectorRequestAccess](../../models/components/createtelegramagentconnectorrequestaccess.md)                                                     | :heavy_check_mark:                                                                                                                                                               | The explicit Telegram chat allowlist permitted to invoke the agent.                                                                                                              |
| `dropPendingUpdates`                                                                                                                                                             | *true*                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                               | Always true: Telegram discards updates queued before this tenancy's webhook is registered.                                                                                       |