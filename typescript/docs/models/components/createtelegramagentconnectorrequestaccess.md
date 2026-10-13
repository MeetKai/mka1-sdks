# CreateTelegramAgentConnectorRequestAccess

The explicit Telegram chat allowlist permitted to invoke the agent.

## Example Usage

```typescript
import { CreateTelegramAgentConnectorRequestAccess } from "@meetkai/mka1/models/components";

let value: CreateTelegramAgentConnectorRequestAccess = {
  mode: "allowlist",
  chatIds: [
    131008,
  ],
};
```

## Fields

| Field                                                                                                                    | Type                                                                                                                     | Required                                                                                                                 | Description                                                                                                              |
| ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ |
| `mode`                                                                                                                   | [components.CreateTelegramAgentConnectorRequestMode](../../models/components/createtelegramagentconnectorrequestmode.md) | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `chatIds`                                                                                                                | *number*[]                                                                                                               | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |