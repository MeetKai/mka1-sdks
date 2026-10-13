# ComputeTenantList

## Example Usage

```typescript
import { ComputeTenantList } from "@meetkai/mka1/models/components";

let value: ComputeTenantList = {
  nextCursor: "<value>",
  total: 233955,
  data: [
    {
      createdAt: new Date("2024-07-14T21:19:06.231Z"),
      enabled: true,
      maxLiveJobs: 44980,
      maxLiveServiceReplicas: 13421,
      maxLiveServices: null,
      maxLiveVolumes: 459254,
      orgId: "<id>",
      updatedAt: new Date("2024-05-07T09:00:57.533Z"),
    },
  ],
};
```

## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `nextCursor`                                                           | *string*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `total`                                                                | *number*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `data`                                                                 | [components.ComputeTenant](../../models/components/computetenant.md)[] | :heavy_check_mark:                                                     | N/A                                                                    |