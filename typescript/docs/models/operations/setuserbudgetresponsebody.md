# SetUserBudgetResponseBody

OK

## Example Usage

```typescript
import { SetUserBudgetResponseBody } from "@meetkai/mka1/models/operations";

let value: SetUserBudgetResponseBody = {
  id: "<id>",
  scope: "user_default",
  scopeId: "<id>",
  scopeOrgId: null,
  owner: "org",
  period: "monthly",
  limit: 2388.17,
  thresholds: [],
  alertWebhookUrl: "https://foolhardy-surface.com/",
  spend: {
    window: "<value>",
    costSpent: 875.89,
    limit: 5653.07,
    pct: 41812,
    status: "ok",
  },
};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                     | *string*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `scope`                                                                                                  | [operations.SetUserBudgetScope](../../models/operations/setuserbudgetscope.md)                           | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `scopeId`                                                                                                | *string*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `scopeOrgId`                                                                                             | *string*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `owner`                                                                                                  | [operations.SetUserBudgetBudgetsOwner](../../models/operations/setuserbudgetbudgetsowner.md)             | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `period`                                                                                                 | [operations.SetUserBudgetBudgetsPeriod](../../models/operations/setuserbudgetbudgetsperiod.md)           | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `limit`                                                                                                  | *number*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `thresholds`                                                                                             | [operations.SetUserBudgetBudgetsThresholds](../../models/operations/setuserbudgetbudgetsthresholds.md)[] | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `alertWebhookUrl`                                                                                        | *string*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `spend`                                                                                                  | [operations.SetUserBudgetSpend](../../models/operations/setuserbudgetspend.md)                           | :heavy_check_mark:                                                                                       | N/A                                                                                                      |