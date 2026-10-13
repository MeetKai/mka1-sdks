# AcceptClusterInviteResponseBody

Organization created

## Example Usage

```typescript
import { AcceptClusterInviteResponseBody } from "@meetkai/mka1/models/operations";

let value: AcceptClusterInviteResponseBody = {
  message: "<value>",
  user: {
    id: "<id>",
  },
  organization: {
    id: "<id>",
    slug: "<value>",
  },
  apiKey: {
    id: "<id>",
    userId: "<id>",
    userType: "service-account",
    orgId: "<id>",
    teamId: "<id>",
    scopes: [],
  },
};
```

## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `message`                                                                                    | *string*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `user`                                                                                       | [operations.User](../../models/operations/user.md)                                           | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `organization`                                                                               | [operations.Organization](../../models/operations/organization.md)                           | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `apiKey`                                                                                     | [operations.AcceptClusterInviteApiKey](../../models/operations/acceptclusterinviteapikey.md) | :heavy_check_mark:                                                                           | N/A                                                                                          |