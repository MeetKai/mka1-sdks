# ComputeUsageData

## Example Usage

```typescript
import { ComputeUsageData } from "@meetkai/mka1/models/components";

let value: ComputeUsageData = {
  accruedUsd: 6282.89,
  billableSeconds: 5299.13,
  name: "<value>",
  resourceId: "<id>",
  resourceType: "job",
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `accruedUsd`                                                                               | *number*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `billableSeconds`                                                                          | *number*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `costBreakdownUsd`                                                                         | [components.CostBreakdownUsd](../../models/components/costbreakdownusd.md)                 | :heavy_minus_sign:                                                                         | N/A                                                                                        |
| `name`                                                                                     | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `replicaSeconds`                                                                           | *number*                                                                                   | :heavy_minus_sign:                                                                         | Summed per-incarnation compute seconds; present for service rows.                          |
| `resourceId`                                                                               | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `resourceType`                                                                             | [components.ComputeUsageResourceType](../../models/components/computeusageresourcetype.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `storedByteSeconds`                                                                        | *number*                                                                                   | :heavy_minus_sign:                                                                         | N/A                                                                                        |
| `storedGibHours`                                                                           | *number*                                                                                   | :heavy_minus_sign:                                                                         | N/A                                                                                        |