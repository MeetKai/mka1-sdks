# PutPricingRequest

## Example Usage

```typescript
import { PutPricingRequest } from "@meetkai/mka1/models/operations";

let value: PutPricingRequest = {
  idempotencyKey: "<value>",
  ifMatch: "<value>",
  computePricingUpdate: {
    volumeStorageUsdPerGibHour: 2628.69,
  },
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `idempotencyKey`                                                                   | *string*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `ifMatch`                                                                          | *string*                                                                           | :heavy_check_mark:                                                                 | Current pricing version. Use 0 for the first write.                                |
| `xOnBehalfOf`                                                                      | *string*                                                                           | :heavy_minus_sign:                                                                 | Optional external end-user identifier forwarded by the API gateway.                |
| `computePricingUpdate`                                                             | [components.ComputePricingUpdate](../../models/components/computepricingupdate.md) | :heavy_check_mark:                                                                 | N/A                                                                                |