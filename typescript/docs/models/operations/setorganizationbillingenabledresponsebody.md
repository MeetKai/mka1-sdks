# SetOrganizationBillingEnabledResponseBody

OK

## Example Usage

```typescript
import { SetOrganizationBillingEnabledResponseBody } from "@meetkai/mka1/models/operations";

let value: SetOrganizationBillingEnabledResponseBody = {
  orgId: "<id>",
  configured: true,
  enabled: false,
  status: "past_due",
  currency: "Bahamian Dollar",
  legalName: "<value>",
  billingEmail: "<value>",
  address: null,
  activatedAt: null,
  currentPeriod: {
    start: "<value>",
    end: "<value>",
  },
  currentUnbilledMinor: 559454,
  outstandingMinor: 971595,
  invoices: [],
};
```

## Fields

| Field                                                                                                                          | Type                                                                                                                           | Required                                                                                                                       | Description                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------ |
| `orgId`                                                                                                                        | *string*                                                                                                                       | :heavy_check_mark:                                                                                                             | N/A                                                                                                                            |
| `configured`                                                                                                                   | *boolean*                                                                                                                      | :heavy_check_mark:                                                                                                             | N/A                                                                                                                            |
| `enabled`                                                                                                                      | *boolean*                                                                                                                      | :heavy_check_mark:                                                                                                             | N/A                                                                                                                            |
| `status`                                                                                                                       | [operations.SetOrganizationBillingEnabledStatus](../../models/operations/setorganizationbillingenabledstatus.md)               | :heavy_check_mark:                                                                                                             | N/A                                                                                                                            |
| `currency`                                                                                                                     | *string*                                                                                                                       | :heavy_check_mark:                                                                                                             | N/A                                                                                                                            |
| `legalName`                                                                                                                    | *string*                                                                                                                       | :heavy_check_mark:                                                                                                             | N/A                                                                                                                            |
| `billingEmail`                                                                                                                 | *string*                                                                                                                       | :heavy_check_mark:                                                                                                             | N/A                                                                                                                            |
| `address`                                                                                                                      | [operations.SetOrganizationBillingEnabledAddress](../../models/operations/setorganizationbillingenabledaddress.md)             | :heavy_check_mark:                                                                                                             | N/A                                                                                                                            |
| `activatedAt`                                                                                                                  | *string*                                                                                                                       | :heavy_check_mark:                                                                                                             | N/A                                                                                                                            |
| `currentPeriod`                                                                                                                | [operations.SetOrganizationBillingEnabledCurrentPeriod](../../models/operations/setorganizationbillingenabledcurrentperiod.md) | :heavy_check_mark:                                                                                                             | N/A                                                                                                                            |
| `currentUnbilledMinor`                                                                                                         | *number*                                                                                                                       | :heavy_check_mark:                                                                                                             | N/A                                                                                                                            |
| `outstandingMinor`                                                                                                             | *number*                                                                                                                       | :heavy_check_mark:                                                                                                             | N/A                                                                                                                            |
| `invoices`                                                                                                                     | [operations.SetOrganizationBillingEnabledInvoices](../../models/operations/setorganizationbillingenabledinvoices.md)[]         | :heavy_check_mark:                                                                                                             | N/A                                                                                                                            |