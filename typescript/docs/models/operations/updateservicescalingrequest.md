# UpdateServiceScalingRequest

## Example Usage

```typescript
import { UpdateServiceScalingRequest } from "@meetkai/mka1/models/operations";

let value: UpdateServiceScalingRequest = {
  id: "<id>",
  idempotencyKey: "<value>",
  computeScalingInput: {
    maxReplicas: 104560,
    minReplicas: 583082,
  },
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `id`                                                                                 | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `idempotencyKey`                                                                     | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `ifMatch`                                                                            | *string*                                                                             | :heavy_minus_sign:                                                                   | Optional strong entity tag containing the current desired scaling-policy generation. |
| `xOnBehalfOf`                                                                        | *string*                                                                             | :heavy_minus_sign:                                                                   | Optional external end-user identifier forwarded by the API gateway.                  |
| `computeScalingInput`                                                                | [components.ComputeScalingInput](../../models/components/computescalinginput.md)     | :heavy_check_mark:                                                                   | N/A                                                                                  |