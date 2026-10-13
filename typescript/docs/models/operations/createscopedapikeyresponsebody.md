# CreateScopedApiKeyResponseBody

Key minted (plaintext returned once)

## Example Usage

```typescript
import { CreateScopedApiKeyResponseBody } from "@meetkai/mka1/models/operations";

let value: CreateScopedApiKeyResponseBody = {
  id: "<id>",
  userId: "<id>",
  userType: "user",
  orgId: null,
  teamId: "<id>",
  scopes: [
    "<value 1>",
    "<value 2>",
    "<value 3>",
  ],
};
```

## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `id`                                                       | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `name`                                                     | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `key`                                                      | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `prefix`                                                   | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `start`                                                    | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `userId`                                                   | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `userType`                                                 | [operations.UserType](../../models/operations/usertype.md) | :heavy_check_mark:                                         | N/A                                                        |
| `orgId`                                                    | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `teamId`                                                   | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `scopes`                                                   | *string*[]                                                 | :heavy_check_mark:                                         | N/A                                                        |
| `expiresAt`                                                | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |