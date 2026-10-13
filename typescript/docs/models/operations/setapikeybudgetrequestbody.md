# SetApiKeyBudgetRequestBody

## Example Usage

```typescript
import { SetApiKeyBudgetRequestBody } from "@meetkai/mka1/models/operations";

let value: SetApiKeyBudgetRequestBody = {
  period: "monthly",
  limit: 2308.36,
  thresholds: [],
};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `owner`                                                                                        | [operations.SetApiKeyBudgetOwner](../../models/operations/setapikeybudgetowner.md)             | :heavy_minus_sign:                                                                             | cluster = operator ceiling (org-admin read-only); org = self-budget                            |
| `period`                                                                                       | [operations.SetApiKeyBudgetPeriod](../../models/operations/setapikeybudgetperiod.md)           | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `limit`                                                                                        | *number*                                                                                       | :heavy_check_mark:                                                                             | Spend limit in major currency units                                                            |
| `thresholds`                                                                                   | [operations.SetApiKeyBudgetThresholds](../../models/operations/setapikeybudgetthresholds.md)[] | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `webhookUrl`                                                                                   | *string*                                                                                       | :heavy_minus_sign:                                                                             | N/A                                                                                            |
| `webhookSecret`                                                                                | *string*                                                                                       | :heavy_minus_sign:                                                                             | N/A                                                                                            |