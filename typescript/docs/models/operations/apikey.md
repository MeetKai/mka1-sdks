# ApiKey

## Example Usage

```typescript
import { ApiKey } from "@meetkai/mka1/models/operations";

let value: ApiKey = {
  id: "<id>",
  userId: "<id>",
  userType: "service-account",
  orgId: "<id>",
  teamId: "<id>",
  scopes: [],
};
```

## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `id`                                                                                     | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `name`                                                                                   | *string*                                                                                 | :heavy_minus_sign:                                                                       | N/A                                                                                      |
| `key`                                                                                    | *string*                                                                                 | :heavy_minus_sign:                                                                       | N/A                                                                                      |
| `prefix`                                                                                 | *string*                                                                                 | :heavy_minus_sign:                                                                       | N/A                                                                                      |
| `start`                                                                                  | *string*                                                                                 | :heavy_minus_sign:                                                                       | N/A                                                                                      |
| `userId`                                                                                 | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `userType`                                                                               | [operations.ReissueOwnerKeyUserType](../../models/operations/reissueownerkeyusertype.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `orgId`                                                                                  | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `teamId`                                                                                 | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `scopes`                                                                                 | *string*[]                                                                               | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `expiresAt`                                                                              | *string*                                                                                 | :heavy_minus_sign:                                                                       | N/A                                                                                      |