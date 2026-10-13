# Data1

## Example Usage

```typescript
import { Data1 } from "@meetkai/mka1/models/operations";

let value: Data1 = {
  id: "<id>",
  scope: "external_user_default",
  scopeId: "<id>",
  scopeOrgId: "<id>",
  owner: "org",
  period: "monthly",
  limit: 9149.87,
  thresholds: [
    {
      pct: 179014,
      action: "block",
    },
  ],
  alertWebhookUrl: "https://alarmed-technologist.biz",
  spend: {
    window: "<value>",
    costSpent: 4470.66,
    limit: 7058.14,
    pct: 911783,
    status: "blocked",
  },
};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `id`                                                                                           | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `scope`                                                                                        | [operations.ListBudgetsDataScope](../../models/operations/listbudgetsdatascope.md)             | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `scopeId`                                                                                      | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `scopeOrgId`                                                                                   | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `owner`                                                                                        | [operations.ListBudgetsDataOwner](../../models/operations/listbudgetsdataowner.md)             | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `period`                                                                                       | [operations.ListBudgetsDataPeriod](../../models/operations/listbudgetsdataperiod.md)           | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `limit`                                                                                        | *number*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `thresholds`                                                                                   | [operations.ListBudgetsDataThresholds](../../models/operations/listbudgetsdatathresholds.md)[] | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `alertWebhookUrl`                                                                              | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `spend`                                                                                        | [operations.DataSpend](../../models/operations/dataspend.md)                                   | :heavy_check_mark:                                                                             | N/A                                                                                            |