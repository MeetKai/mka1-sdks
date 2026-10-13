# SetupWhatsAppAppWebhookResponse

## Example Usage

```typescript
import { SetupWhatsAppAppWebhookResponse } from "@meetkai/mka1/models/operations";

let value: SetupWhatsAppAppWebhookResponse = {
  headers: {},
  result: {
    object: "agent.connector.whatsapp_webhook_setup",
    appId: "<id>",
    callbackUrl: "https://linear-drug.org",
    verifyToken: "<value>",
  },
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `headers`                                                                          | Record<string, *string*[]>                                                         | :heavy_check_mark:                                                                 | N/A                                                                                |
| `result`                                                                           | [components.WhatsAppWebhookSetup](../../models/components/whatsappwebhooksetup.md) | :heavy_check_mark:                                                                 | N/A                                                                                |