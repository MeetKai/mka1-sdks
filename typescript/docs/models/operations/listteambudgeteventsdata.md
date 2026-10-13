# ListTeamBudgetEventsData

## Example Usage

```typescript
import { ListTeamBudgetEventsData } from "@meetkai/mka1/models/operations";

let value: ListTeamBudgetEventsData = {
  id: "<id>",
  budgetId: "<id>",
  type: "blocked",
  pct: 3626.21,
  periodKey: "<value>",
  targetId: "<id>",
  spendSnapshot: 3081.87,
  limitSnapshot: 7590.97,
  createdAt: "1730059924514",
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `id`                                                                                       | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `budgetId`                                                                                 | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `type`                                                                                     | [operations.ListTeamBudgetEventsType](../../models/operations/listteambudgeteventstype.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `pct`                                                                                      | *number*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `periodKey`                                                                                | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `targetId`                                                                                 | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `spendSnapshot`                                                                            | *number*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `limitSnapshot`                                                                            | *number*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `createdAt`                                                                                | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |