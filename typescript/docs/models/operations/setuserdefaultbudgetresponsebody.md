# SetUserDefaultBudgetResponseBody

OK

## Example Usage

```typescript
import { SetUserDefaultBudgetResponseBody } from "@meetkai/mka1/models/operations";

let value: SetUserDefaultBudgetResponseBody = {
  id: "<id>",
  scope: "user_default",
  scopeId: "<id>",
  scopeOrgId: "<id>",
  owner: "cluster",
  period: "monthly",
  limit: 2822.75,
  thresholds: [
    {
      pct: 108542,
      action: "block",
    },
  ],
  alertWebhookUrl: "https://secondary-accelerator.net",
};
```

## Fields

| Field                                                                                                                  | Type                                                                                                                   | Required                                                                                                               | Description                                                                                                            |
| ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                   | *string*                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `scope`                                                                                                                | [operations.SetUserDefaultBudgetScope](../../models/operations/setuserdefaultbudgetscope.md)                           | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `scopeId`                                                                                                              | *string*                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `scopeOrgId`                                                                                                           | *string*                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `owner`                                                                                                                | [operations.SetUserDefaultBudgetBudgetsOwner](../../models/operations/setuserdefaultbudgetbudgetsowner.md)             | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `period`                                                                                                               | [operations.SetUserDefaultBudgetBudgetsPeriod](../../models/operations/setuserdefaultbudgetbudgetsperiod.md)           | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `limit`                                                                                                                | *number*                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `thresholds`                                                                                                           | [operations.SetUserDefaultBudgetBudgetsThresholds](../../models/operations/setuserdefaultbudgetbudgetsthresholds.md)[] | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |
| `alertWebhookUrl`                                                                                                      | *string*                                                                                                               | :heavy_check_mark:                                                                                                     | N/A                                                                                                                    |