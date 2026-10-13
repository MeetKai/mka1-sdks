# UpdateOrganizationBillingProfileResponseBody

OK

## Example Usage

```typescript
import { UpdateOrganizationBillingProfileResponseBody } from "@meetkai/mka1/models/operations";

let value: UpdateOrganizationBillingProfileResponseBody = {
  orgId: "<id>",
  configured: true,
  enabled: false,
  status: "disabled",
  currency: "Nakfa",
  legalName: null,
  billingEmail: "<value>",
  address: null,
  activatedAt: null,
  currentPeriod: {
    start: "<value>",
    end: "<value>",
  },
  currentUnbilledMinor: 181846,
  outstandingMinor: 3399,
  invoices: [
    {
      id: "<id>",
      periodStart: "<value>",
      periodEnd: "<value>",
      currency: "Liberian Dollar",
      amountDueMinor: 498107,
      amountPaidMinor: 244912,
      status: "<value>",
      hostedInvoiceUrl: "https://shameful-humidity.net",
      pdfUrl: "https://fine-whale.biz/",
    },
  ],
};
```

## Fields

| Field                                                                                                                                | Type                                                                                                                                 | Required                                                                                                                             | Description                                                                                                                          |
| ------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------ |
| `orgId`                                                                                                                              | *string*                                                                                                                             | :heavy_check_mark:                                                                                                                   | N/A                                                                                                                                  |
| `configured`                                                                                                                         | *boolean*                                                                                                                            | :heavy_check_mark:                                                                                                                   | N/A                                                                                                                                  |
| `enabled`                                                                                                                            | *boolean*                                                                                                                            | :heavy_check_mark:                                                                                                                   | N/A                                                                                                                                  |
| `status`                                                                                                                             | [operations.UpdateOrganizationBillingProfileStatus](../../models/operations/updateorganizationbillingprofilestatus.md)               | :heavy_check_mark:                                                                                                                   | N/A                                                                                                                                  |
| `currency`                                                                                                                           | *string*                                                                                                                             | :heavy_check_mark:                                                                                                                   | N/A                                                                                                                                  |
| `legalName`                                                                                                                          | *string*                                                                                                                             | :heavy_check_mark:                                                                                                                   | N/A                                                                                                                                  |
| `billingEmail`                                                                                                                       | *string*                                                                                                                             | :heavy_check_mark:                                                                                                                   | N/A                                                                                                                                  |
| `address`                                                                                                                            | [operations.UpdateOrganizationBillingProfileAddress](../../models/operations/updateorganizationbillingprofileaddress.md)             | :heavy_check_mark:                                                                                                                   | N/A                                                                                                                                  |
| `activatedAt`                                                                                                                        | *string*                                                                                                                             | :heavy_check_mark:                                                                                                                   | N/A                                                                                                                                  |
| `currentPeriod`                                                                                                                      | [operations.UpdateOrganizationBillingProfileCurrentPeriod](../../models/operations/updateorganizationbillingprofilecurrentperiod.md) | :heavy_check_mark:                                                                                                                   | N/A                                                                                                                                  |
| `currentUnbilledMinor`                                                                                                               | *number*                                                                                                                             | :heavy_check_mark:                                                                                                                   | N/A                                                                                                                                  |
| `outstandingMinor`                                                                                                                   | *number*                                                                                                                             | :heavy_check_mark:                                                                                                                   | N/A                                                                                                                                  |
| `invoices`                                                                                                                           | [operations.UpdateOrganizationBillingProfileInvoices](../../models/operations/updateorganizationbillingprofileinvoices.md)[]         | :heavy_check_mark:                                                                                                                   | N/A                                                                                                                                  |