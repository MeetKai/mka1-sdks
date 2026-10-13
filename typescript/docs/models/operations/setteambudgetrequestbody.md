# SetTeamBudgetRequestBody

## Example Usage

```typescript
import { SetTeamBudgetRequestBody } from "@meetkai/mka1/models/operations";

let value: SetTeamBudgetRequestBody = {
  period: "daily",
  limit: 7816.02,
  thresholds: [],
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `owner`                                                                                    | [operations.SetTeamBudgetOwner](../../models/operations/setteambudgetowner.md)             | :heavy_minus_sign:                                                                         | cluster = operator ceiling (org-admin read-only); org = self-budget                        |
| `period`                                                                                   | [operations.SetTeamBudgetPeriod](../../models/operations/setteambudgetperiod.md)           | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `limit`                                                                                    | *number*                                                                                   | :heavy_check_mark:                                                                         | Spend limit in major currency units                                                        |
| `thresholds`                                                                               | [operations.SetTeamBudgetThresholds](../../models/operations/setteambudgetthresholds.md)[] | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `webhookUrl`                                                                               | *string*                                                                                   | :heavy_minus_sign:                                                                         | N/A                                                                                        |
| `webhookSecret`                                                                            | *string*                                                                                   | :heavy_minus_sign:                                                                         | N/A                                                                                        |