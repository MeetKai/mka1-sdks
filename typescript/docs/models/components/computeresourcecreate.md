# ComputeResourceCreate

## Example Usage

```typescript
import { ComputeResourceCreate } from "@meetkai/mka1/models/components";

let value: ComputeResourceCreate = {
  compute: {
    accelerator: "<value>",
    ephemeralDiskGb: 133945,
    gpuCount: 438176,
  },
  container: {
    image: "https://loremflickr.com/1288/320?lock=2331794271158214",
    scriptB64: "<value>",
  },
};
```

## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `access`                                                                                             | [components.ComputeAccessCreate](../../models/components/computeaccesscreate.md)                     | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `compute`                                                                                            | [components.ComputeRequest](../../models/components/computerequest.md)                               | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `container`                                                                                          | *components.ComputeContainerCreate*                                                                  | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `limits`                                                                                             | [components.ComputeLimits](../../models/components/computelimits.md)                                 | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `name`                                                                                               | *string*                                                                                             | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `placement`                                                                                          | [components.ComputePlacement](../../models/components/computeplacement.md)                           | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `service`                                                                                            | [components.ComputeServiceInput](../../models/components/computeserviceinput.md)                     | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `volumes`                                                                                            | [components.ComputeStandaloneVolumeMount](../../models/components/computestandalonevolumemount.md)[] | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |