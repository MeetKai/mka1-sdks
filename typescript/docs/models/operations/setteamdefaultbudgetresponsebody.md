# SetTeamDefaultBudgetResponseBody

OK

## Example Usage

```typescript
import { SetTeamDefaultBudgetResponseBody } from "@meetkai/mka1/models/operations";

let value: SetTeamDefaultBudgetResponseBody = {
  id: "<id>",
  scope: "apikey",
  scopeId: "<id>",
  scopeOrgId: "<id>",
  owner: "cluster",
  period: "monthly",
  limit: 4053.63,
  thresholds: [],
  alertWebhookUrl: "https://cheap-coordination.biz",
};
```

## Fields

| Field                                                                                                                  | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                   | *string*                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `scope`                                                                                                                | [operations.SetTeamDefaultBudgetScope](../../models/operations/setteamdefaultbudgetscope.md)                           | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `scopeId`                                                                                                              | *string*                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `scopeOrgId`                                                                                                           | *string*                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `owner`                                                                                                                | [operations.SetTeamDefaultBudgetBudgetsOwner](../../models/operations/setteamdefaultbudgetbudgetsowner.md)             | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `period`                                                                                                               | [operations.SetTeamDefaultBudgetBudgetsPeriod](../../models/operations/setteamdefaultbudgetbudgetsperiod.md)           | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `limit`                                                                                                                | *number*                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `thresholds`                                                                                                           | [operations.SetTeamDefaultBudgetBudgetsThresholds](../../models/operations/setteamdefaultbudgetbudgetsthresholds.md)[] | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `alertWebhookUrl`                                                                                                      | *string*                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |