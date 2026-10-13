# SetExternalUserBudgetRequestBody

## Example Usage

```typescript
import { SetExternalUserBudgetRequestBody } from "@meetkai/mka1/models/operations";

let value: SetExternalUserBudgetRequestBody = {
  period: "daily",
  limit: 5976.64,
  thresholds: [],
};
```

## Fields

| Field                                                                                                      | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `owner`                                                                                                    | [operations.SetExternalUserBudgetOwner](../../models/operations/setexternaluserbudgetowner.md)             | :heavy_minus_sign:                                                                                         | cluster = operator ceiling (org-admin read-only); org = self-budget                                        |
| `period`                                                                                                   | [operations.SetExternalUserBudgetPeriod](../../models/operations/setexternaluserbudgetperiod.md)           | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `limit`                                                                                                    | *number*                                                                                                   | :heavy_check_mark:                                                                                         | Spend limit in major currency units                                                                        |
| `thresholds`                                                                                               | [operations.SetExternalUserBudgetThresholds](../../models/operations/setexternaluserbudgetthresholds.md)[] | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `webhookUrl`                                                                                               | *string*                                                                                                   | :heavy_minus_sign:                                                                                         | N/A                                                                                                        |
| `webhookSecret`                                                                                            | *string*                                                                                                   | :heavy_minus_sign:                                                                                         | N/A                                                                                                        |