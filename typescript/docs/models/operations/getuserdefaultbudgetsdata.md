# GetUserDefaultBudgetsData

## Example Usage

```typescript
import { GetUserDefaultBudgetsData } from "@meetkai/mka1/models/operations";

let value: GetUserDefaultBudgetsData = {
  id: "<id>",
  scope: "user",
  scopeId: "<id>",
  scopeOrgId: "<id>",
  owner: "cluster",
  period: "daily",
  limit: 2855.7,
  thresholds: [
    {
      pct: 108911,
      action: "block",
    },
  ],
  alertWebhookUrl: null,
};
```

## Fields

| Field                                                                                                      | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                       | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `scope`                                                                                                    | [operations.GetUserDefaultBudgetsScope](../../models/operations/getuserdefaultbudgetsscope.md)             | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `scopeId`                                                                                                  | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `scopeOrgId`                                                                                               | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `owner`                                                                                                    | [operations.GetUserDefaultBudgetsOwner](../../models/operations/getuserdefaultbudgetsowner.md)             | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `period`                                                                                                   | [operations.GetUserDefaultBudgetsPeriod](../../models/operations/getuserdefaultbudgetsperiod.md)           | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `limit`                                                                                                    | *number*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `thresholds`                                                                                               | [operations.GetUserDefaultBudgetsThresholds](../../models/operations/getuserdefaultbudgetsthresholds.md)[] | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `alertWebhookUrl`                                                                                          | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |