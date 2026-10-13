# SetOrgBudgetResponseBody

OK

## Example Usage

```typescript
import { SetOrgBudgetResponseBody } from "@meetkai/mka1/models/operations";

let value: SetOrgBudgetResponseBody = {
  id: "<id>",
  scope: "team_default",
  scopeId: "<id>",
  scopeOrgId: "<id>",
  owner: "cluster",
  period: "monthly",
  limit: 4064.42,
  thresholds: [
    {
      pct: 140982,
      action: "alert",
    },
  ],
  alertWebhookUrl: "https://thrifty-substitution.org/",
  spend: {
    window: "<value>",
    costSpent: 7151.89,
    limit: 3068.43,
    pct: 819582,
    status: "blocked",
  },
};
```

## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `id`                                                                                     | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `scope`                                                                                  | [operations.Scope](../../models/operations/scope.md)                                     | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `scopeId`                                                                                | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `scopeOrgId`                                                                             | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `owner`                                                                                  | [operations.SetOrgBudgetOwner](../../models/operations/setorgbudgetowner.md)             | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `period`                                                                                 | [operations.SetOrgBudgetPeriod](../../models/operations/setorgbudgetperiod.md)           | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `limit`                                                                                  | *number*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `thresholds`                                                                             | [operations.SetOrgBudgetThresholds](../../models/operations/setorgbudgetthresholds.md)[] | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `alertWebhookUrl`                                                                        | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `spend`                                                                                  | [operations.Spend](../../models/operations/spend.md)                                     | :heavy_check_mark:                                                                       | N/A                                                                                      |