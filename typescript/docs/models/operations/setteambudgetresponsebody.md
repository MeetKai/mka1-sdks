# SetTeamBudgetResponseBody

OK

## Example Usage

```typescript
import { SetTeamBudgetResponseBody } from "@meetkai/mka1/models/operations";

let value: SetTeamBudgetResponseBody = {
  id: "<id>",
  scope: "team_default",
  scopeId: "<id>",
  scopeOrgId: "<id>",
  owner: "cluster",
  period: "monthly",
  limit: 227.35,
  thresholds: [
    {
      pct: 202943,
      action: "block",
    },
  ],
  alertWebhookUrl: "https://upright-license.biz/",
  spend: {
    window: "<value>",
    costSpent: 7452.85,
    limit: 2954.49,
    pct: 654248,
    status: "blocked",
  },
};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                     | *string*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `scope`                                                                                                  | [operations.SetTeamBudgetScope](../../models/operations/setteambudgetscope.md)                           | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `scopeId`                                                                                                | *string*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `scopeOrgId`                                                                                             | *string*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `owner`                                                                                                  | [operations.SetTeamBudgetBudgetsOwner](../../models/operations/setteambudgetbudgetsowner.md)             | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `period`                                                                                                 | [operations.SetTeamBudgetBudgetsPeriod](../../models/operations/setteambudgetbudgetsperiod.md)           | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `limit`                                                                                                  | *number*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `thresholds`                                                                                             | [operations.SetTeamBudgetBudgetsThresholds](../../models/operations/setteambudgetbudgetsthresholds.md)[] | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `alertWebhookUrl`                                                                                        | *string*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `spend`                                                                                                  | [operations.SetTeamBudgetSpend](../../models/operations/setteambudgetspend.md)                           | :heavy_check_mark:                                                                                       | N/A                                                                                                      |