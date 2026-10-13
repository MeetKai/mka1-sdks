# GetJwtFromKeyResponseBody

Successfully exchanged API key for a JWT token

## Example Usage

```typescript
import { GetJwtFromKeyResponseBody } from "@meetkai/mka1/models/operations";

let value: GetJwtFromKeyResponseBody = {
  token: "<value>",
};
```

## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `token`                                                            | *string*                                                           | :heavy_check_mark:                                                 | Signed JWT exchange token to use when calling downstream services. |