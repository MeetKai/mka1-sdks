# Credentials

## Example Usage

```typescript
import { Credentials } from "@meetkai/mka1/models/components";

let value: Credentials = {
  botToken: "<value>",
};
```

## Fields

| Field                                                                                             | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `botToken`                                                                                        | *string*                                                                                          | :heavy_check_mark:                                                                                | Telegram bot token issued by BotFather. It is encrypted at rest and is never returned by the API. |