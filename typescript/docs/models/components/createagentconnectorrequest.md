# CreateAgentConnectorRequest


## Supported Types

### `components.CreateTelegramAgentConnectorRequest`

```typescript
const value: components.CreateTelegramAgentConnectorRequest = {
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

### `components.CreateWhatsAppAgentConnectorRequest`

```typescript
const value: components.CreateWhatsAppAgentConnectorRequest = {
  provider: "whatsapp",
  credentials: {
    accessToken: "<value>",
    appSecret: "<value>",
  },
  account: {
    appId: "<id>",
    whatsappBusinessAccountId: "<id>",
    phoneNumberId: "<id>",
  },
  access: {
    mode: "allowlist",
    userIds: [
      "<value 1>",
    ],
  },
};
```

