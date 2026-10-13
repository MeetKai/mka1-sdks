# CreateStandaloneVolumeRequest

## Example Usage

```typescript
import { CreateStandaloneVolumeRequest } from "@meetkai/mka1/models/operations";

let value: CreateStandaloneVolumeRequest = {
  idempotencyKey: "<value>",
  computeStandaloneVolumeCreate: {
    name: "<value>",
  },
};
```

## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `idempotencyKey`                                                                                     | *string*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `xOnBehalfOf`                                                                                        | *string*                                                                                             | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |
| `computeStandaloneVolumeCreate`                                                                      | [components.ComputeStandaloneVolumeCreate](../../models/components/computestandalonevolumecreate.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |