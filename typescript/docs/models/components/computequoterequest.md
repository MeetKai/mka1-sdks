# ComputeQuoteRequest

## Example Usage

```typescript
import { ComputeQuoteRequest } from "@meetkai/mka1/models/components";

let value: ComputeQuoteRequest = {
  compute: {
    accelerator: "<value>",
    ephemeralDiskGb: 133945,
    gpuCount: 438176,
  },
  container: {
    image: "https://loremflickr.com/2920/449?lock=7599160431540206",
  },
  resourceType: "service",
};
```

## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `access`                                                                                             | [components.ComputeQuoteRequestAccess](../../models/components/computequoterequestaccess.md)         | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `compute`                                                                                            | [components.ComputeRequest](../../models/components/computerequest.md)                               | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `container`                                                                                          | [components.ComputeQuoteRequestContainer](../../models/components/computequoterequestcontainer.md)   | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `placement`                                                                                          | [components.ComputePlacement](../../models/components/computeplacement.md)                           | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `resourceType`                                                                                       | [components.ComputeResourceType](../../models/components/computeresourcetype.md)                     | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `service`                                                                                            | [components.Service](../../models/components/service.md)                                             | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |
| `volumes`                                                                                            | [components.ComputeStandaloneVolumeMount](../../models/components/computestandalonevolumemount.md)[] | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |