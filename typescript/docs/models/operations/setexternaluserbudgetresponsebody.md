# SetExternalUserBudgetResponseBody

OK

## Example Usage

```typescript
import { SetExternalUserBudgetResponseBody } from "@meetkai/mka1/models/operations";

let value: SetExternalUserBudgetResponseBody = {
  id: "<id>",
  scope: "user",
  scopeId: "<id>",
  scopeOrgId: "<id>",
  owner: "cluster",
  period: "monthly",
  limit: 6171.6,
  thresholds: [
    {
      pct: 932979,
      action: "block",
    },
  ],
  alertWebhookUrl: "https://muddy-elver.net",
  spend: {
    window: "<value>",
    costSpent: 3275.32,
    limit: 6260.85,
    pct: 242408,
    status: "ok",
  },
};
```

## Fields

| Field                                                                                                                    | Type                                                                                                                     | Required                                                                                                                 | Description                                                                                                              |
| ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ |
| `id`                                                                                                                     | *string*                                                                                                                 | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `scope`                                                                                                                  | [operations.SetExternalUserBudgetScope](../../models/operations/setexternaluserbudgetscope.md)                           | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `scopeId`                                                                                                                | *string*                                                                                                                 | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `scopeOrgId`                                                                                                             | *string*                                                                                                                 | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `owner`                                                                                                                  | [operations.SetExternalUserBudgetBudgetsOwner](../../models/operations/setexternaluserbudgetbudgetsowner.md)             | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `period`                                                                                                                 | [operations.SetExternalUserBudgetBudgetsPeriod](../../models/operations/setexternaluserbudgetbudgetsperiod.md)           | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `limit`                                                                                                                  | *number*                                                                                                                 | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `thresholds`                                                                                                             | [operations.SetExternalUserBudgetBudgetsThresholds](../../models/operations/setexternaluserbudgetbudgetsthresholds.md)[] | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `alertWebhookUrl`                                                                                                        | *string*                                                                                                                 | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `spend`                                                                                                                  | [operations.SetExternalUserBudgetSpend](../../models/operations/setexternaluserbudgetspend.md)                           | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |