# SetOrganizationBillingEnabledInvoices

## Example Usage

```typescript
import { SetOrganizationBillingEnabledInvoices } from "@meetkai/mka1/models/operations";

let value: SetOrganizationBillingEnabledInvoices = {
  id: "<id>",
  periodStart: "<value>",
  periodEnd: "<value>",
  currency: "Jamaican Dollar",
  amountDueMinor: 325427,
  amountPaidMinor: 191648,
  status: "<value>",
  hostedInvoiceUrl: "https://musty-discourse.org",
  pdfUrl: "https://good-armoire.biz",
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `id`               | *string*           | :heavy_check_mark: | N/A                |
| `periodStart`      | *string*           | :heavy_check_mark: | N/A                |
| `periodEnd`        | *string*           | :heavy_check_mark: | N/A                |
| `currency`         | *string*           | :heavy_check_mark: | N/A                |
| `amountDueMinor`   | *number*           | :heavy_check_mark: | N/A                |
| `amountPaidMinor`  | *number*           | :heavy_check_mark: | N/A                |
| `status`           | *string*           | :heavy_check_mark: | N/A                |
| `hostedInvoiceUrl` | *string*           | :heavy_check_mark: | N/A                |
| `pdfUrl`           | *string*           | :heavy_check_mark: | N/A                |