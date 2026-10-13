# ListServiceAccountApiKeysResponseBody

## Example Usage

```typescript
import { ListServiceAccountApiKeysResponseBody } from "@meetkai/mka1/models/operations";

let value: ListServiceAccountApiKeysResponseBody = {
  id: "<id>",
  userId: "<id>",
  userType: "service-account",
  orgId: null,
  teamId: "<id>",
  scopes: [
    "<value 1>",
    "<value 2>",
  ],
};
```

## Fields

| Field                                                                                                        | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `id`                                                                                                         | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `name`                                                                                                       | *string*                                                                                                     | :heavy_minus_sign:                                                                                           | N/A                                                                                                          |
| `key`                                                                                                        | *string*                                                                                                     | :heavy_minus_sign:                                                                                           | N/A                                                                                                          |
| `prefix`                                                                                                     | *string*                                                                                                     | :heavy_minus_sign:                                                                                           | N/A                                                                                                          |
| `start`                                                                                                      | *string*                                                                                                     | :heavy_minus_sign:                                                                                           | N/A                                                                                                          |
| `userId`                                                                                                     | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `userType`                                                                                                   | [operations.ListServiceAccountApiKeysUserType](../../models/operations/listserviceaccountapikeysusertype.md) | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `orgId`                                                                                                      | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `teamId`                                                                                                     | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `scopes`                                                                                                     | *string*[]                                                                                                   | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `expiresAt`                                                                                                  | *string*                                                                                                     | :heavy_minus_sign:                                                                                           | N/A                                                                                                          |