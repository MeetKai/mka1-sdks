# GetApiKeyBudgetsData

## Example Usage

```typescript
import { GetApiKeyBudgetsData } from "@meetkai/mka1/models/operations";

let value: GetApiKeyBudgetsData = {
  id: "<id>",
  scope: "user",
  scopeId: "<id>",
  scopeOrgId: "<id>",
  owner: "cluster",
  period: "monthly",
  limit: 4333.99,
  thresholds: [
    {
      pct: 652515,
      action: "block",
    },
  ],
  alertWebhookUrl: "https://shimmering-overcoat.biz",
  spend: {
    window: "<value>",
    costSpent: 7311.25,
    limit: 3727.24,
    pct: 342301,
    status: "ok",
  },
};
```

## Fields

| Field                                                                                            | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `id`                                                                                             | *string*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `scope`                                                                                          | [operations.GetApiKeyBudgetsScope](../../models/operations/getapikeybudgetsscope.md)             | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `scopeId`                                                                                        | *string*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `scopeOrgId`                                                                                     | *string*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `owner`                                                                                          | [operations.GetApiKeyBudgetsOwner](../../models/operations/getapikeybudgetsowner.md)             | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `period`                                                                                         | [operations.GetApiKeyBudgetsPeriod](../../models/operations/getapikeybudgetsperiod.md)           | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `limit`                                                                                          | *number*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `thresholds`                                                                                     | [operations.GetApiKeyBudgetsThresholds](../../models/operations/getapikeybudgetsthresholds.md)[] | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `alertWebhookUrl`                                                                                | *string*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `spend`                                                                                          | [operations.GetApiKeyBudgetsSpend](../../models/operations/getapikeybudgetsspend.md)             | :heavy_check_mark:                                                                               | N/A                                                                                              |