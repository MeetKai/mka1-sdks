# ListOrgBudgetEventsData

## Example Usage

```typescript
import { ListOrgBudgetEventsData } from "@meetkai/mka1/models/operations";

let value: ListOrgBudgetEventsData = {
  id: "<id>",
  budgetId: "<id>",
  type: "threshold_alert",
  pct: 9023.96,
  periodKey: "<value>",
  targetId: "<id>",
  spendSnapshot: 317.51,
  limitSnapshot: 5559.85,
  createdAt: "1715487061845",
};
```

## Fields

| Field                                              | Type                                               | Required                                           | Description                                        |
| -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- |
| `id`                                               | *string*                                           | :heavy_check_mark:                                 | N/A                                                |
| `budgetId`                                         | *string*                                           | :heavy_check_mark:                                 | N/A                                                |
| `type`                                             | [operations.Type](../../models/operations/type.md) | :heavy_check_mark:                                 | N/A                                                |
| `pct`                                              | *number*                                           | :heavy_check_mark:                                 | N/A                                                |
| `periodKey`                                        | *string*                                           | :heavy_check_mark:                                 | N/A                                                |
| `targetId`                                         | *string*                                           | :heavy_check_mark:                                 | N/A                                                |
| `spendSnapshot`                                    | *number*                                           | :heavy_check_mark:                                 | N/A                                                |
| `limitSnapshot`                                    | *number*                                           | :heavy_check_mark:                                 | N/A                                                |
| `createdAt`                                        | *string*                                           | :heavy_check_mark:                                 | N/A                                                |