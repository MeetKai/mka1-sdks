# UpdateOrganizationRequest

## Example Usage

```typescript
import { UpdateOrganizationRequest } from "@meetkai/mka1/models/operations";

let value: UpdateOrganizationRequest = {
  orgId: "<id>",
  updateOrganizationBody: {
    metadata: {},
  },
};
```

## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `orgId`                                                                                | *string*                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `xOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |
| `updateOrganizationBody`                                                               | [components.UpdateOrganizationBody](../../models/components/updateorganizationbody.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |