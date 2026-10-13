# SetTeamDefaultBudgetRequestBody

## Example Usage

```typescript
import { SetTeamDefaultBudgetRequestBody } from "@meetkai/mka1/models/operations";

let value: SetTeamDefaultBudgetRequestBody = {
  period: "monthly",
  limit: 7039.38,
  thresholds: [
    {
      pct: 984337,
      action: "alert",
    },
  ],
};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `owner`                                                                                                  | [operations.SetTeamDefaultBudgetOwner](../../models/operations/setteamdefaultbudgetowner.md)             | :heavy_minus_sign:                                                                                       | cluster = operator ceiling (org-admin read-only); org = self-budget                                      |
| `period`                                                                                                 | [operations.SetTeamDefaultBudgetPeriod](../../models/operations/setteamdefaultbudgetperiod.md)           | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `limit`                                                                                                  | *number*                                                                                                 | :heavy_check_mark:                                                                                       | Spend limit in major currency units                                                                      |
| `thresholds`                                                                                             | [operations.SetTeamDefaultBudgetThresholds](../../models/operations/setteamdefaultbudgetthresholds.md)[] | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `webhookUrl`                                                                                             | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | N/A                                                                                                      |
| `webhookSecret`                                                                                          | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | N/A                                                                                                      |