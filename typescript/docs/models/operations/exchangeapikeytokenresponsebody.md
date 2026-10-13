# ExchangeApiKeyTokenResponseBody

Signed JWT

## Example Usage

```typescript
import { ExchangeApiKeyTokenResponseBody } from "@meetkai/mka1/models/operations";

let value: ExchangeApiKeyTokenResponseBody = {
  token: "<value>",
};
```

## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `token`                                                            | *string*                                                           | :heavy_check_mark:                                                 | Signed JWT exchange token to use when calling downstream services. |