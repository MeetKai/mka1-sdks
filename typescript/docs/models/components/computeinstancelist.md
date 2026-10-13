# ComputeInstanceList

## Example Usage

```typescript
import { ComputeInstanceList } from "@meetkai/mka1/models/components";

let value: ComputeInstanceList = {
  nextCursor: "<value>",
  total: 790212,
  data: [
    {
      endpoints: [],
      hardware: {
        accelerator: "<value>",
        gpuCount: 664993,
        gpuMemoryGb: 985896,
      },
      id: "<id>",
      providerId: "<id>",
      providerResourceType: "<value>",
      state: "starting",
    },
  ],
};
```

## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `nextCursor`                                                               | *string*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `total`                                                                    | *number*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `data`                                                                     | [components.ComputeInstance](../../models/components/computeinstance.md)[] | :heavy_check_mark:                                                         | N/A                                                                        |