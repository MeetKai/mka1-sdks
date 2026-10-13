# ListTeamBudgetEventsResponseBody

OK

## Example Usage

```typescript
import { ListTeamBudgetEventsResponseBody } from "@meetkai/mka1/models/operations";

let value: ListTeamBudgetEventsResponseBody = {
  object: "list",
  data: [
    {
      id: "<id>",
      budgetId: "<id>",
      type: "threshold_alert",
      pct: 2581.83,
      periodKey: "<value>",
      targetId: "<id>",
      spendSnapshot: 924.32,
      limitSnapshot: 2863.33,
      createdAt: "1710185606990",
    },
  ],
};
```

## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `object`                                                                                     | *"list"*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `data`                                                                                       | [operations.ListTeamBudgetEventsData](../../models/operations/listteambudgeteventsdata.md)[] | :heavy_check_mark:                                                                           | N/A                                                                                          |