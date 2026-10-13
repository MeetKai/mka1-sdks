# SetUserBudgetRequestBody

## Example Usage

```typescript
import { SetUserBudgetRequestBody } from "@meetkai/mka1/models/operations";

let value: SetUserBudgetRequestBody = {
  period: "weekly",
  limit: 9574.75,
  thresholds: [
    {
      pct: 814516,
      action: "block",
    },
  ],
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `owner`                                                                                    | [operations.SetUserBudgetOwner](../../models/operations/setuserbudgetowner.md)             | :heavy_minus_sign:                                                                         | cluster = operator ceiling (org-admin read-only); org = self-budget                        |
| `period`                                                                                   | [operations.SetUserBudgetPeriod](../../models/operations/setuserbudgetperiod.md)           | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `limit`                                                                                    | *number*                                                                                   | :heavy_check_mark:                                                                         | Spend limit in major currency units                                                        |
| `thresholds`                                                                               | [operations.SetUserBudgetThresholds](../../models/operations/setuserbudgetthresholds.md)[] | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `webhookUrl`                                                                               | *string*                                                                                   | :heavy_minus_sign:                                                                         | N/A                                                                                        |
| `webhookSecret`                                                                            | *string*                                                                                   | :heavy_minus_sign:                                                                         | N/A                                                                                        |