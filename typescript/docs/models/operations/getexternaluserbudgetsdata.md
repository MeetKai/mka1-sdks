# GetExternalUserBudgetsData

## Example Usage

```typescript
import { GetExternalUserBudgetsData } from "@meetkai/mka1/models/operations";

let value: GetExternalUserBudgetsData = {
  id: "<id>",
  scope: "org",
  scopeId: "<id>",
  scopeOrgId: null,
  owner: "org",
  period: "weekly",
  limit: 8723.31,
  thresholds: [],
  alertWebhookUrl: null,
  spend: {
    window: "<value>",
    costSpent: 5897.27,
    limit: 6721.26,
    pct: 906779,
    status: "blocked",
  },
};
```

## Fields

| Field                                                                                                        | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `id`                                                                                                         | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `scope`                                                                                                      | [operations.GetExternalUserBudgetsScope](../../models/operations/getexternaluserbudgetsscope.md)             | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `scopeId`                                                                                                    | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `scopeOrgId`                                                                                                 | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `owner`                                                                                                      | [operations.GetExternalUserBudgetsOwner](../../models/operations/getexternaluserbudgetsowner.md)             | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `period`                                                                                                     | [operations.GetExternalUserBudgetsPeriod](../../models/operations/getexternaluserbudgetsperiod.md)           | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `limit`                                                                                                      | *number*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `thresholds`                                                                                                 | [operations.GetExternalUserBudgetsThresholds](../../models/operations/getexternaluserbudgetsthresholds.md)[] | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `alertWebhookUrl`                                                                                            | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `spend`                                                                                                      | [operations.GetExternalUserBudgetsSpend](../../models/operations/getexternaluserbudgetsspend.md)             | :heavy_check_mark:                                                                                           | N/A                                                                                                          |