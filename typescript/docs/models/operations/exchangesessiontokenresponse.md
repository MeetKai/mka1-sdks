# ExchangeSessionTokenResponse

## Example Usage

```typescript
import { ExchangeSessionTokenResponse } from "@meetkai/mka1/models/operations";

let value: ExchangeSessionTokenResponse = {
  headers: {
    "key": [],
  },
  result: {
    token: "<value>",
    expiresAt: new Date("2024-04-15T04:06:04.707Z"),
  },
};
```

## Fields

| Field                                                                                                      | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `headers`                                                                                                  | Record<string, *string*[]>                                                                                 | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `result`                                                                                                   | [operations.ExchangeSessionTokenResponseBody](../../models/operations/exchangesessiontokenresponsebody.md) | :heavy_check_mark:                                                                                         | N/A                                                                                                        |