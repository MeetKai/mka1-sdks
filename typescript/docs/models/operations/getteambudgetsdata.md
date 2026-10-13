# GetTeamBudgetsData

## Example Usage

```typescript
import { GetTeamBudgetsData } from "@meetkai/mka1/models/operations";

let value: GetTeamBudgetsData = {
  id: "<id>",
  scope: "org",
  scopeId: "<id>",
  scopeOrgId: "<id>",
  owner: "cluster",
  period: "weekly",
  limit: 370.09,
  thresholds: [
    {
      pct: 274634,
      action: "block",
    },
  ],
  alertWebhookUrl: "https://elliptical-hello.name",
  spend: {
    window: "<value>",
    costSpent: 5520.93,
    limit: 1908.23,
    pct: 567358,
    status: "ok",
  },
};
```

## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `id`                                                                                         | *string*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `scope`                                                                                      | [operations.GetTeamBudgetsScope](../../models/operations/getteambudgetsscope.md)             | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `scopeId`                                                                                    | *string*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `scopeOrgId`                                                                                 | *string*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `owner`                                                                                      | [operations.GetTeamBudgetsOwner](../../models/operations/getteambudgetsowner.md)             | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `period`                                                                                     | [operations.GetTeamBudgetsPeriod](../../models/operations/getteambudgetsperiod.md)           | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `limit`                                                                                      | *number*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `thresholds`                                                                                 | [operations.GetTeamBudgetsThresholds](../../models/operations/getteambudgetsthresholds.md)[] | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `alertWebhookUrl`                                                                            | *string*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `spend`                                                                                      | [operations.GetTeamBudgetsSpend](../../models/operations/getteambudgetsspend.md)             | :heavy_check_mark:                                                                           | N/A                                                                                          |