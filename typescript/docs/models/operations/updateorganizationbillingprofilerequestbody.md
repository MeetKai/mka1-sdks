# UpdateOrganizationBillingProfileRequestBody

## Example Usage

```typescript
import { UpdateOrganizationBillingProfileRequestBody } from "@meetkai/mka1/models/operations";

let value: UpdateOrganizationBillingProfileRequestBody = {
  legalName: "<value>",
  billingEmail: "Erwin30@gmail.com",
  address: {
    line1: "<value>",
    city: "Pasqualemouth",
    postalCode: "02932-8865",
    country: "Sri Lanka",
  },
};
```

## Fields

| Field                                                    | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `legalName`                                              | *string*                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `billingEmail`                                           | *string*                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `address`                                                | [operations.Address](../../models/operations/address.md) | :heavy_check_mark:                                       | N/A                                                      |