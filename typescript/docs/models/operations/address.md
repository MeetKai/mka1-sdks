# Address

## Example Usage

```typescript
import { Address } from "@meetkai/mka1/models/operations";

let value: Address = {
  line1: "<value>",
  city: "South Rosalindport",
  postalCode: "82269",
  country: "Svalbard & Jan Mayen Islands",
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `line1`            | *string*           | :heavy_check_mark: | N/A                |
| `line2`            | *string*           | :heavy_minus_sign: | N/A                |
| `city`             | *string*           | :heavy_check_mark: | N/A                |
| `state`            | *string*           | :heavy_minus_sign: | N/A                |
| `postalCode`       | *string*           | :heavy_check_mark: | N/A                |
| `country`          | *string*           | :heavy_check_mark: | N/A                |