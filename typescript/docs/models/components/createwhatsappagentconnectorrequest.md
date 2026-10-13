# CreateWhatsAppAgentConnectorRequest

Beta WhatsApp Cloud API connector configuration.

## Example Usage

```typescript
import { CreateWhatsAppAgentConnectorRequest } from "@meetkai/mka1/models/components";

let value: CreateWhatsAppAgentConnectorRequest = {
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

## Fields

| Field                                                                                                                                  | Type                                                                                                                                   | Required                                                                                                                               | Description                                                                                                                            |
| -------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- |
| `provider`                                                                                                                             | *"whatsapp"*                                                                                                                           | :heavy_check_mark:                                                                                                                     | Beta WhatsApp Cloud API connector with text, image, document, and native thumbs-reaction feedback support.                             |
| `name`                                                                                                                                 | *string*                                                                                                                               | :heavy_minus_sign:                                                                                                                     | N/A                                                                                                                                    |
| `credentials`                                                                                                                          | [components.CreateWhatsAppAgentConnectorRequestCredentials](../../models/components/createwhatsappagentconnectorrequestcredentials.md) | :heavy_check_mark:                                                                                                                     | N/A                                                                                                                                    |
| `account`                                                                                                                              | [components.Account](../../models/components/account.md)                                                                               | :heavy_check_mark:                                                                                                                     | N/A                                                                                                                                    |
| `access`                                                                                                                               | [components.CreateWhatsAppAgentConnectorRequestAccess](../../models/components/createwhatsappagentconnectorrequestaccess.md)           | :heavy_check_mark:                                                                                                                     | Exact WhatsApp sender IDs permitted to invoke the agent. These are digit strings without a leading plus sign.                          |