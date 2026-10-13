# SetupWhatsAppAppWebhookRequest

## Example Usage

```typescript
import { SetupWhatsAppAppWebhookRequest } from "@meetkai/mka1/models/operations";

let value: SetupWhatsAppAppWebhookRequest = {
  id: "<id>",
  whatsAppWebhookSetupRequest: {
    appId: "<id>",
  },
};
```

## Fields

| Field                                                                                            | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `id`                                                                                             | *string*                                                                                         | :heavy_check_mark:                                                                               | The agent ID.                                                                                    |
| `xOnBehalfOf`                                                                                    | *string*                                                                                         | :heavy_minus_sign:                                                                               | Optional external end-user identifier forwarded by the API gateway.                              |
| `whatsAppWebhookSetupRequest`                                                                    | [components.WhatsAppWebhookSetupRequest](../../models/components/whatsappwebhooksetuprequest.md) | :heavy_check_mark:                                                                               | N/A                                                                                              |