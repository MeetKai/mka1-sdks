# ComputeOfferList

## Example Usage

```typescript
import { ComputeOfferList } from "@meetkai/mka1/models/components";

let value: ComputeOfferList = {
  nextCursor: "<value>",
  total: 870907,
  data: [],
};
```

## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `nextCursor`                                                         | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `total`                                                              | *number*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `data`                                                               | [components.ComputeOffer](../../models/components/computeoffer.md)[] | :heavy_check_mark:                                                   | N/A                                                                  |