# GetOrgBudgetsData

## Example Usage

```typescript
import { GetOrgBudgetsData } from "@meetkai/mka1/models/operations";

let value: GetOrgBudgetsData = {
  id: "<id>",
  scope: "external_user",
  scopeId: "<id>",
  scopeOrgId: "<id>",
  owner: "cluster",
  period: "weekly",
  limit: 6899.14,
  thresholds: [
    {
      pct: 888957,
      action: "alert",
    },
  ],
  alertWebhookUrl: "https://stupendous-contractor.info/",
  spend: {
    window: "<value>",
    costSpent: 1036.17,
    limit: 2756.86,
    pct: 825341,
    status: "ok",
  },
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `id`                                                                                       | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `scope`                                                                                    | [operations.GetOrgBudgetsScope](../../models/operations/getorgbudgetsscope.md)             | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `scopeId`                                                                                  | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `scopeOrgId`                                                                               | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `owner`                                                                                    | [operations.GetOrgBudgetsOwner](../../models/operations/getorgbudgetsowner.md)             | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `period`                                                                                   | [operations.GetOrgBudgetsPeriod](../../models/operations/getorgbudgetsperiod.md)           | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `limit`                                                                                    | *number*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `thresholds`                                                                               | [operations.GetOrgBudgetsThresholds](../../models/operations/getorgbudgetsthresholds.md)[] | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `alertWebhookUrl`                                                                          | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `spend`                                                                                    | [operations.GetOrgBudgetsSpend](../../models/operations/getorgbudgetsspend.md)             | :heavy_check_mark:                                                                         | N/A                                                                                        |