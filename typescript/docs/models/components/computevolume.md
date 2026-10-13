# ComputeVolume

## Example Usage

```typescript
import { ComputeVolume } from "@meetkai/mka1/models/components";

let value: ComputeVolume = {
  accruedCostUsd: 6784.77,
  data: [],
  mountPath: "<value>",
  priceUsdHr: 2679.59,
  sizeGb: 209369,
  status: "provisioning",
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `accruedCostUsd`                                                                 | *number*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `data`                                                                           | [components.ComputeVolumeData](../../models/components/computevolumedata.md)[]   | :heavy_check_mark:                                                               | N/A                                                                              |
| `mountPath`                                                                      | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `priceUsdHr`                                                                     | *number*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `sizeGb`                                                                         | *number*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `status`                                                                         | [components.ComputeVolumeStatus](../../models/components/computevolumestatus.md) | :heavy_check_mark:                                                               | N/A                                                                              |