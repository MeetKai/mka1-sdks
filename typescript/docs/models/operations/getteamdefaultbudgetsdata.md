# GetTeamDefaultBudgetsData

## Example Usage

```typescript
import { GetTeamDefaultBudgetsData } from "@meetkai/mka1/models/operations";

let value: GetTeamDefaultBudgetsData = {
  id: "<id>",
  scope: "user_default",
  scopeId: "<id>",
  scopeOrgId: "<id>",
  owner: "org",
  period: "weekly",
  limit: 8697.61,
  thresholds: [
    {
      pct: 353874,
      action: "alert",
    },
  ],
  alertWebhookUrl: "https://true-hydrolyse.com/",
};
```

## Fields

| Field                                                                                                      | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                       | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `scope`                                                                                                    | [operations.GetTeamDefaultBudgetsScope](../../models/operations/getteamdefaultbudgetsscope.md)             | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `scopeId`                                                                                                  | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `scopeOrgId`                                                                                               | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `owner`                                                                                                    | [operations.GetTeamDefaultBudgetsOwner](../../models/operations/getteamdefaultbudgetsowner.md)             | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `period`                                                                                                   | [operations.GetTeamDefaultBudgetsPeriod](../../models/operations/getteamdefaultbudgetsperiod.md)           | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `limit`                                                                                                    | *number*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `thresholds`                                                                                               | [operations.GetTeamDefaultBudgetsThresholds](../../models/operations/getteamdefaultbudgetsthresholds.md)[] | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `alertWebhookUrl`                                                                                          | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |