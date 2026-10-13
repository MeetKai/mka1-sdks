# UsageCostsResponse

## Example Usage

```typescript
import { UsageCostsResponse } from "@meetkai/mka1/models/components";

let value: UsageCostsResponse = {
  object: "usage.costs",
  currency: "East Caribbean Dollar",
  startTime: 237550,
  endTime: 910887,
  groupBy: [
    "org_id",
  ],
  data: [
    {
      model: "Silverado",
      apiKeyId: "<id>",
      teamId: "<id>",
      externalUserId: "<id>",
      orgId: "<id>",
      cost: 1377.31,
      costNano: "<value>",
    },
  ],
  totalCost: 6657.39,
  totalCostNano: "<value>",
};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `object`                                                                                                 | *"usage.costs"*                                                                                          | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `currency`                                                                                               | *string*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `startTime`                                                                                              | *number*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `endTime`                                                                                                | *number*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `groupBy`                                                                                                | [components.CostsUsageGroupBy](../../models/components/costsusagegroupby.md)[]                           | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `data`                                                                                                   | [components.CostGroupRow](../../models/components/costgrouprow.md)[]                                     | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `totalCost`                                                                                              | *number*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `totalCostNano`                                                                                          | *string*                                                                                                 | :heavy_check_mark:                                                                                       | Total cost in integer NANO-units (1e9 per major unit, NOT cents); use `total_cost` for the major amount. |