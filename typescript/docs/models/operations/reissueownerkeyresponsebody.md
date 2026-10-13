# ReissueOwnerKeyResponseBody

Owner key re-issued (plaintext returned once)

## Example Usage

```typescript
import { ReissueOwnerKeyResponseBody } from "@meetkai/mka1/models/operations";

let value: ReissueOwnerKeyResponseBody = {
  message: "<value>",
  userId: "<id>",
  apiKey: {
    id: "<id>",
    userId: "<id>",
    userType: "service-account",
    orgId: "<id>",
    teamId: "<id>",
    scopes: [
      "<value 1>",
    ],
  },
};
```

## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `message`                                              | *string*                                               | :heavy_check_mark:                                     | N/A                                                    |
| `userId`                                               | *string*                                               | :heavy_check_mark:                                     | N/A                                                    |
| `apiKey`                                               | [operations.ApiKey](../../models/operations/apikey.md) | :heavy_check_mark:                                     | N/A                                                    |