# UpdateOrganizationBillingProfileInvoices

## Example Usage

```typescript
import { UpdateOrganizationBillingProfileInvoices } from "@meetkai/mka1/models/operations";

let value: UpdateOrganizationBillingProfileInvoices = {
  id: "<id>",
  periodStart: "<value>",
  periodEnd: "<value>",
  currency: "Turkish Lira",
  amountDueMinor: 40738,
  amountPaidMinor: 663414,
  status: "<value>",
  hostedInvoiceUrl: "https://expert-bathhouse.org",
  pdfUrl: "https://trusty-schnitzel.com",
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