# ComputeOffer

## Example Usage

```typescript
import { ComputeOffer } from "@meetkai/mka1/models/components";

let value: ComputeOffer = {
  available: true,
  capabilities: {
    customImage: false,
    httpPorts: true,
    managedService: true,
    multiNode: false,
    persistentVolume: false,
    privateImage: false,
    scaleToZero: false,
    sharedVolume: false,
    ssh: false,
    standaloneVolume: false,
    tcpPorts: false,
  },
  compute: {
    accelerator: "<value>",
    ephemeralDiskGb: 782499,
    gpuCount: 246848,
    gpuMemoryGb: 633746,
    instanceCount: 419480,
    memoryGb: 517772,
    vcpus: 649961,
  },
  expiresAt: null,
  observedAt: new Date("2025-08-31T12:40:05.018Z"),
  priceUsdHr: 6587.93,
  provider: "<value>",
  providerSku: "<value>",
  region: {
    name: "<value>",
  },
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `available`                                                                                   | *boolean*                                                                                     | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `capabilities`                                                                                | [components.ComputeOfferCapabilities](../../models/components/computeoffercapabilities.md)    | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `compute`                                                                                     | [components.Compute](../../models/components/compute.md)                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `expiresAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `observedAt`                                                                                  | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `priceUsdHr`                                                                                  | *number*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `provider`                                                                                    | *string*                                                                                      | :heavy_check_mark:                                                                            | Opaque compute-provider identifier. Supported values are deployment-specific.                 |
| `providerSku`                                                                                 | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `region`                                                                                      | [components.Region](../../models/components/region.md)                                        | :heavy_check_mark:                                                                            | N/A                                                                                           |