# SetApiKeyBudgetResponseBody

OK

## Example Usage

```typescript
import { SetApiKeyBudgetResponseBody } from "@meetkai/mka1/models/operations";

let value: SetApiKeyBudgetResponseBody = {
  id: "<id>",
  scope: "external_user",
  scopeId: "<id>",
  scopeOrgId: "<id>",
  owner: "org",
  period: "daily",
  limit: 7466.55,
  thresholds: [
    {
      pct: 578788,
      action: "alert",
    },
  ],
  alertWebhookUrl: "https://yearly-thunderbolt.org/",
  spend: {
    window: "<value>",
    costSpent: 6750.89,
    limit: 6135.07,
    pct: 292089,
    status: "ok",
  },
};
```

## Fields

| Field                                                                                                        | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `id`                                                                                                         | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `scope`                                                                                                      | [operations.SetApiKeyBudgetScope](../../models/operations/setapikeybudgetscope.md)                           | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `scopeId`                                                                                                    | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `scopeOrgId`                                                                                                 | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `owner`                                                                                                      | [operations.SetApiKeyBudgetBudgetsOwner](../../models/operations/setapikeybudgetbudgetsowner.md)             | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `period`                                                                                                     | [operations.SetApiKeyBudgetBudgetsPeriod](../../models/operations/setapikeybudgetbudgetsperiod.md)           | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `limit`                                                                                                      | *number*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `thresholds`                                                                                                 | [operations.SetApiKeyBudgetBudgetsThresholds](../../models/operations/setapikeybudgetbudgetsthresholds.md)[] | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `alertWebhookUrl`                                                                                            | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `spend`                                                                                                      | [operations.SetApiKeyBudgetSpend](../../models/operations/setapikeybudgetspend.md)                           | :heavy_check_mark:                                                                                           | N/A                                                                                                          |