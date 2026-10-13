# CreateWhatsAppAgentConnectorRequestAccess

Exact WhatsApp sender IDs permitted to invoke the agent. These are digit strings without a leading plus sign.

## Example Usage

```typescript
import { CreateWhatsAppAgentConnectorRequestAccess } from "@meetkai/mka1/models/components";

let value: CreateWhatsAppAgentConnectorRequestAccess = {
  mode: "allowlist",
  userIds: [
    "<value 1>",
    "<value 2>",
    "<value 3>",
  ],
};
```

## Fields

| Field                                                                                                                    | Type                                                                                                                     | Required                                                                                                                 | Description                                                                                                              |
| ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ |
| `mode`                                                                                                                   | [components.CreateWhatsAppAgentConnectorRequestMode](../../models/components/createwhatsappagentconnectorrequestmode.md) | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `userIds`                                                                                                                | *string*[]                                                                                                               | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |