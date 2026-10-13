# ListExternalUserBudgetEventsData

## Example Usage

```typescript
import { ListExternalUserBudgetEventsData } from "@meetkai/mka1/models/operations";

let value: ListExternalUserBudgetEventsData = {
  id: "<id>",
  budgetId: "<id>",
  type: "threshold_alert",
  pct: 7873.53,
  periodKey: "<value>",
  targetId: "<id>",
  spendSnapshot: 5188.08,
  limitSnapshot: 7063.41,
  createdAt: "1715733765786",
};
```

## Fields

| Field                                                                                                      | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                       | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `budgetId`                                                                                                 | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `type`                                                                                                     | [operations.ListExternalUserBudgetEventsType](../../models/operations/listexternaluserbudgeteventstype.md) | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `pct`                                                                                                      | *number*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `periodKey`                                                                                                | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `targetId`                                                                                                 | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `spendSnapshot`                                                                                            | *number*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `limitSnapshot`                                                                                            | *number*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `createdAt`                                                                                                | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |