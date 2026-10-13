# Invoices

## Example Usage

```typescript
import { Invoices } from "@meetkai/mka1/models/operations";

let value: Invoices = {
  id: "<id>",
  periodStart: "<value>",
  periodEnd: "<value>",
  currency: "Tugrik",
  amountDueMinor: 340254,
  amountPaidMinor: 717917,
  status: "<value>",
  hostedInvoiceUrl: "https://mild-attraction.info",
  pdfUrl: "https://trusting-shore.net/",
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