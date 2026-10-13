# SetUserDefaultBudgetRequestBody

## Example Usage

```typescript
import { SetUserDefaultBudgetRequestBody } from "@meetkai/mka1/models/operations";

let value: SetUserDefaultBudgetRequestBody = {
  period: "daily",
  limit: 7170.6,
  thresholds: [
    {
      pct: 778062,
      action: "block",
    },
  ],
};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `owner`                                                                                                  | [operations.SetUserDefaultBudgetOwner](../../models/operations/setuserdefaultbudgetowner.md)             | :heavy_minus_sign:                                                                                       | cluster = operator ceiling (org-admin read-only); org = self-budget                                      |
| `period`                                                                                                 | [operations.SetUserDefaultBudgetPeriod](../../models/operations/setuserdefaultbudgetperiod.md)           | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `limit`                                                                                                  | *number*                                                                                                 | :heavy_check_mark:                                                                                       | Spend limit in major currency units                                                                      |
| `thresholds`                                                                                             | [operations.SetUserDefaultBudgetThresholds](../../models/operations/setuserdefaultbudgetthresholds.md)[] | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `webhookUrl`                                                                                             | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | N/A                                                                                                      |
| `webhookSecret`                                                                                          | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | N/A                                                                                                      |