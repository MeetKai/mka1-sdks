# SetOrgBudgetRequestBody

## Example Usage

```typescript
import { SetOrgBudgetRequestBody } from "@meetkai/mka1/models/operations";

let value: SetOrgBudgetRequestBody = {
  period: "daily",
  limit: 90.56,
  thresholds: [],
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `owner`                                                             | [operations.Owner](../../models/operations/owner.md)                | :heavy_minus_sign:                                                  | cluster = operator ceiling (org-admin read-only); org = self-budget |
| `period`                                                            | [operations.Period](../../models/operations/period.md)              | :heavy_check_mark:                                                  | N/A                                                                 |
| `limit`                                                             | *number*                                                            | :heavy_check_mark:                                                  | Spend limit in major currency units                                 |
| `thresholds`                                                        | [operations.Thresholds](../../models/operations/thresholds.md)[]    | :heavy_check_mark:                                                  | N/A                                                                 |
| `webhookUrl`                                                        | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `webhookSecret`                                                     | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |