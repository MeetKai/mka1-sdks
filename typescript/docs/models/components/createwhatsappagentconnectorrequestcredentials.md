# CreateWhatsAppAgentConnectorRequestCredentials

## Example Usage

```typescript
import { CreateWhatsAppAgentConnectorRequestCredentials } from "@meetkai/mka1/models/components";

let value: CreateWhatsAppAgentConnectorRequestCredentials = {
  accessToken: "<value>",
  appSecret: "<value>",
};
```

## Fields

| Field                                                                                                                                                               | Type                                                                                                                                                                | Required                                                                                                                                                            | Description                                                                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `accessToken`                                                                                                                                                       | *string*                                                                                                                                                            | :heavy_check_mark:                                                                                                                                                  | Long-lived Meta system-user access token with whatsapp_business_messaging and whatsapp_business_management permissions. It is encrypted at rest and never returned. |
| `appSecret`                                                                                                                                                         | *string*                                                                                                                                                            | :heavy_check_mark:                                                                                                                                                  | Meta app secret used to authenticate webhook payloads. It is encrypted at rest and never returned.                                                                  |