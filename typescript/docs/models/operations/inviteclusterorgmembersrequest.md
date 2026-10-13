# InviteClusterOrgMembersRequest

## Example Usage

```typescript
import { InviteClusterOrgMembersRequest } from "@meetkai/mka1/models/operations";

let value: InviteClusterOrgMembersRequest = {
  id: "<id>",
  requestBody: {
    invitations: [
      {
        email: "Remington42@hotmail.com",
      },
    ],
  },
};
```

## Fields

| Field                                                                                                          | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                           | *string*                                                                                                       | :heavy_check_mark:                                                                                             | N/A                                                                                                            |
| `xOnBehalfOf`                                                                                                  | *string*                                                                                                       | :heavy_minus_sign:                                                                                             | Optional external end-user identifier forwarded by the API gateway.                                            |
| `requestBody`                                                                                                  | [operations.InviteClusterOrgMembersRequestBody](../../models/operations/inviteclusterorgmembersrequestbody.md) | :heavy_check_mark:                                                                                             | N/A                                                                                                            |