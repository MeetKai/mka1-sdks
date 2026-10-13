# ComputeJob

## Example Usage

```typescript
import { ComputeJob } from "@meetkai/mka1/models/components";

let value: ComputeJob = {
  accruedUsd: 6477.52,
  compute: {
    accelerator: "<value>",
    ephemeralDiskGb: 133945,
    gpuCount: 438176,
  },
  createdAt: new Date("2025-06-03T16:36:10.819Z"),
  endpoints: [
    {
      host: "elliptical-humor.biz",
      name: "<value>",
      port: 792702,
      protocol: "<value>",
    },
  ],
  id: "<id>",
  limits: {},
  reason: null,
  startedAt: null,
  state: "succeeded",
  terminalAt: new Date("2025-12-30T07:00:54.473Z"),
};
```

## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `accruedUsd`                                                                                         | *number*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `allocatedAt`                                                                                        | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)        | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `compute`                                                                                            | [components.ComputeRequest](../../models/components/computerequest.md)                               | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `createdAt`                                                                                          | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)        | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `currentPriceUsdHr`                                                                                  | *number*                                                                                             | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `endpoints`                                                                                          | [components.ComputeEndpoint](../../models/components/computeendpoint.md)[]                           | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `hardware`                                                                                           | [components.ComputeHardware](../../models/components/computehardware.md)                             | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `id`                                                                                                 | *string*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `instancePriceUsdHr`                                                                                 | *number*                                                                                             | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `limits`                                                                                             | [components.ComputeLimits](../../models/components/computelimits.md)                                 | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `name`                                                                                               | *string*                                                                                             | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `priceUsdHr`                                                                                         | *number*                                                                                             | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `pricingModel`                                                                                       | [components.PricingModel](../../models/components/pricingmodel.md)                                   | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `provider`                                                                                           | *string*                                                                                             | :heavy_minus_sign:                                                                                   | Opaque compute-provider identifier. Supported values are deployment-specific.                        |
| `reason`                                                                                             | [components.ComputeReason](../../models/components/computereason.md)                                 | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `ssh`                                                                                                | [components.ComputeSSH](../../models/components/computessh.md)                                       | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `startedAt`                                                                                          | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)        | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `state`                                                                                              | [components.ComputeResourceState](../../models/components/computeresourcestate.md)                   | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `terminalAt`                                                                                         | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)        | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `volumes`                                                                                            | [components.ComputeStandaloneVolumeMount](../../models/components/computestandalonevolumemount.md)[] | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `exitCode`                                                                                           | *number*                                                                                             | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |