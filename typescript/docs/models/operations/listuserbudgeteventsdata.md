# ListUserBudgetEventsData

## Example Usage

```typescript
import { ListUserBudgetEventsData } from "@meetkai/mka1/models/operations";

let value: ListUserBudgetEventsData = {
  id: "<id>",
  budgetId: "<id>",
  type: "threshold_alert",
  pct: 5759.31,
  periodKey: "<value>",
  targetId: "<id>",
  spendSnapshot: 6563.19,
  limitSnapshot: 1257.55,
  createdAt: "1723769991539",
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `id`                                                                                       | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `budgetId`                                                                                 | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `type`                                                                                     | [operations.ListUserBudgetEventsType](../../models/operations/listuserbudgeteventstype.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `pct`                                                                                      | *number*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `periodKey`                                                                                | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `targetId`                                                                                 | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `spendSnapshot`                                                                            | *number*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `limitSnapshot`                                                                            | *number*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `createdAt`                                                                                | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |