# SetExternalUserDefaultBudgetRequestBody

## Example Usage

```typescript
import { SetExternalUserDefaultBudgetRequestBody } from "@meetkai/mka1/models/operations";

let value: SetExternalUserDefaultBudgetRequestBody = {
  period: "daily",
  limit: 4221.71,
  thresholds: [
    {
      pct: 691226,
      action: "block",
    },
  ],
};
```

## Fields

| Field                                                                                                                    | Type                                                                                                                     | Required                                                                                                                 | Description                                                                                                              |
| ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ |
| `owner`                                                                                                                  | [operations.SetExternalUserDefaultBudgetOwner](../../models/operations/setexternaluserdefaultbudgetowner.md)             | :heavy_minus_sign:                                                                                                       | cluster = operator ceiling (org-admin read-only); org = self-budget                                                      |
| `period`                                                                                                                 | [operations.SetExternalUserDefaultBudgetPeriod](../../models/operations/setexternaluserdefaultbudgetperiod.md)           | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `limit`                                                                                                                  | *number*                                                                                                                 | :heavy_check_mark:                                                                                                       | Spend limit in major currency units                                                                                      |
| `thresholds`                                                                                                             | [operations.SetExternalUserDefaultBudgetThresholds](../../models/operations/setexternaluserdefaultbudgetthresholds.md)[] | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |
| `webhookUrl`                                                                                                             | *string*                                                                                                                 | :heavy_minus_sign:                                                                                                       | N/A                                                                                                                      |
| `webhookSecret`                                                                                                          | *string*                                                                                                                 | :heavy_minus_sign:                                                                                                       | N/A                                                                                                                      |