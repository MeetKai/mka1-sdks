# GetOrganizationBillingResponseBody

OK

## Example Usage

```typescript
import { GetOrganizationBillingResponseBody } from "@meetkai/mka1/models/operations";

let value: GetOrganizationBillingResponseBody = {
  orgId: "<id>",
  configured: false,
  enabled: false,
  status: "past_due",
  currency: "Zloty",
  legalName: "<value>",
  billingEmail: null,
  address: null,
  activatedAt: "<value>",
  currentPeriod: {
    start: "<value>",
    end: "<value>",
  },
  currentUnbilledMinor: 704752,
  outstandingMinor: 422550,
  invoices: [
    {
      id: "<id>",
      periodStart: "<value>",
      periodEnd: "<value>",
      currency: "Tugrik",
      amountDueMinor: 340254,
      amountPaidMinor: 717917,
      status: "<value>",
      hostedInvoiceUrl: "https://mild-attraction.info",
      pdfUrl: "https://trusting-shore.net/",
    },
  ],
};
```

## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `orgId`                                                                                              | *string*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `configured`                                                                                         | *boolean*                                                                                            | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `enabled`                                                                                            | *boolean*                                                                                            | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `status`                                                                                             | [operations.GetOrganizationBillingStatus](../../models/operations/getorganizationbillingstatus.md)   | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `currency`                                                                                           | *string*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `legalName`                                                                                          | *string*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `billingEmail`                                                                                       | *string*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `address`                                                                                            | [operations.GetOrganizationBillingAddress](../../models/operations/getorganizationbillingaddress.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `activatedAt`                                                                                        | *string*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `currentPeriod`                                                                                      | [operations.CurrentPeriod](../../models/operations/currentperiod.md)                                 | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `currentUnbilledMinor`                                                                               | *number*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `outstandingMinor`                                                                                   | *number*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `invoices`                                                                                           | [operations.Invoices](../../models/operations/invoices.md)[]                                         | :heavy_check_mark:                                                                                   | N/A                                                                                                  |