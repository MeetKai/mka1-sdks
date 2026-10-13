# ListOrgBudgetEventsResponseBody

OK

## Example Usage

```typescript
import { ListOrgBudgetEventsResponseBody } from "@meetkai/mka1/models/operations";

let value: ListOrgBudgetEventsResponseBody = {
  object: "list",
  data: [
    {
      id: "<id>",
      budgetId: "<id>",
      type: "blocked",
      pct: 3942.89,
      periodKey: "<value>",
      targetId: "<id>",
      spendSnapshot: 4002.31,
      limitSnapshot: 6918.41,
      createdAt: "1715299343677",
    },
  ],
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `object`                                                                                   | *"list"*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `data`                                                                                     | [operations.ListOrgBudgetEventsData](../../models/operations/listorgbudgeteventsdata.md)[] | :heavy_check_mark:                                                                         | N/A                                                                                        |