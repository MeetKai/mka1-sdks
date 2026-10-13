# Account

## Example Usage

```typescript
import { Account } from "@meetkai/mka1/models/components";

let value: Account = {
  appId: "<id>",
  whatsappBusinessAccountId: "<id>",
  phoneNumberId: "<id>",
};
```

## Fields

| Field                                                                                                                                           | Type                                                                                                                                            | Required                                                                                                                                        | Description                                                                                                                                     |
| ----------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- |
| `appId`                                                                                                                                         | *string*                                                                                                                                        | :heavy_check_mark:                                                                                                                              | Meta app ID. It is used with the app secret to verify that the system-user token belongs to this app and has the required WhatsApp permissions. |
| `whatsappBusinessAccountId`                                                                                                                     | *string*                                                                                                                                        | :heavy_check_mark:                                                                                                                              | N/A                                                                                                                                             |
| `phoneNumberId`                                                                                                                                 | *string*                                                                                                                                        | :heavy_check_mark:                                                                                                                              | N/A                                                                                                                                             |