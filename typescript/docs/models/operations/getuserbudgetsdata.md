# GetUserBudgetsData

## Example Usage

```typescript
import { GetUserBudgetsData } from "@meetkai/mka1/models/operations";

let value: GetUserBudgetsData = {
  id: "<id>",
  scope: "external_user",
  scopeId: "<id>",
  scopeOrgId: "<id>",
  owner: "org",
  period: "weekly",
  limit: 7362.72,
  thresholds: [],
  alertWebhookUrl: "https://brilliant-printer.net",
  spend: {
    window: "<value>",
    costSpent: 9610.71,
    limit: 5397.88,
    pct: 48791,
    status: "blocked",
  },
};
```

## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `id`                                                                                         | *string*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `scope`                                                                                      | [operations.GetUserBudgetsScope](../../models/operations/getuserbudgetsscope.md)             | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `scopeId`                                                                                    | *string*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `scopeOrgId`                                                                                 | *string*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `owner`                                                                                      | [operations.GetUserBudgetsOwner](../../models/operations/getuserbudgetsowner.md)             | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `period`                                                                                     | [operations.GetUserBudgetsPeriod](../../models/operations/getuserbudgetsperiod.md)           | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `limit`                                                                                      | *number*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `thresholds`                                                                                 | [operations.GetUserBudgetsThresholds](../../models/operations/getuserbudgetsthresholds.md)[] | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `alertWebhookUrl`                                                                            | *string*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `spend`                                                                                      | [operations.GetUserBudgetsSpend](../../models/operations/getuserbudgetsspend.md)             | :heavy_check_mark:                                                                           | N/A                                                                                          |