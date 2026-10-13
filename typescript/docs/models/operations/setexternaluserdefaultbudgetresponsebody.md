# SetExternalUserDefaultBudgetResponseBody

OK

## Example Usage

```typescript
import { SetExternalUserDefaultBudgetResponseBody } from "@meetkai/mka1/models/operations";

let value: SetExternalUserDefaultBudgetResponseBody = {
  id: "<id>",
  scope: "org",
  scopeId: "<id>",
  scopeOrgId: "<id>",
  owner: "cluster",
  period: "monthly",
  limit: 4945.7,
  thresholds: [
    {
      pct: 271157,
      action: "alert",
    },
  ],
  alertWebhookUrl: "https://extra-large-yogurt.net",
};
```

## Fields

| Field                                                                                                                                  | Type                                                                                                                                   | Required                                                                                                                               | Description                                                                                                                            |
| -------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                                   | *string*                                                                                                                               | :heavy_check_mark:                                                                                                                     | N/A                                                                                                                                    |
| `scope`                                                                                                                                | [operations.SetExternalUserDefaultBudgetScope](../../models/operations/setexternaluserdefaultbudgetscope.md)                           | :heavy_check_mark:                                                                                                                     | N/A                                                                                                                                    |
| `scopeId`                                                                                                                              | *string*                                                                                                                               | :heavy_check_mark:                                                                                                                     | N/A                                                                                                                                    |
| `scopeOrgId`                                                                                                                           | *string*                                                                                                                               | :heavy_check_mark:                                                                                                                     | N/A                                                                                                                                    |
| `owner`                                                                                                                                | [operations.SetExternalUserDefaultBudgetBudgetsOwner](../../models/operations/setexternaluserdefaultbudgetbudgetsowner.md)             | :heavy_check_mark:                                                                                                                     | N/A                                                                                                                                    |
| `period`                                                                                                                               | [operations.SetExternalUserDefaultBudgetBudgetsPeriod](../../models/operations/setexternaluserdefaultbudgetbudgetsperiod.md)           | :heavy_check_mark:                                                                                                                     | N/A                                                                                                                                    |
| `limit`                                                                                                                                | *number*                                                                                                                               | :heavy_check_mark:                                                                                                                     | N/A                                                                                                                                    |
| `thresholds`                                                                                                                           | [operations.SetExternalUserDefaultBudgetBudgetsThresholds](../../models/operations/setexternaluserdefaultbudgetbudgetsthresholds.md)[] | :heavy_check_mark:                                                                                                                     | N/A                                                                                                                                    |
| `alertWebhookUrl`                                                                                                                      | *string*                                                                                                                               | :heavy_check_mark:                                                                                                                     | N/A                                                                                                                                    |