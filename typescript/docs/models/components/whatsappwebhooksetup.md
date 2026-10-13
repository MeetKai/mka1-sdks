# WhatsAppWebhookSetup

## Example Usage

```typescript
import { WhatsAppWebhookSetup } from "@meetkai/mka1/models/components";

let value: WhatsAppWebhookSetup = {
  object: "agent.connector.whatsapp_webhook_setup",
  appId: "<id>",
  callbackUrl: "https://unused-cinder.net/",
  verifyToken: "<value>",
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `object`                                                                                           | [components.WhatsAppWebhookSetupObject](../../models/components/whatsappwebhooksetupobject.md)     | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `appId`                                                                                            | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `callbackUrl`                                                                                      | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `verifyToken`                                                                                      | *string*                                                                                           | :heavy_check_mark:                                                                                 | Stable verification value for Meta's app-level Webhooks form. This is not a Meta API access token. |