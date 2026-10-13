# GetExternalUserDefaultBudgetsData

## Example Usage

```typescript
import { GetExternalUserDefaultBudgetsData } from "@meetkai/mka1/models/operations";

let value: GetExternalUserDefaultBudgetsData = {
  id: "<id>",
  scope: "org",
  scopeId: "<id>",
  scopeOrgId: "<id>",
  owner: "cluster",
  period: "daily",
  limit: 2577.44,
  thresholds: [],
  alertWebhookUrl: "https://impeccable-suv.biz",
};
```

## Fields

| Field                                                                                                                      | Type                                                                                                                       | Required                                                                                                                   | Description                                                                                                                |
| -------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                       | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `scope`                                                                                                                    | [operations.GetExternalUserDefaultBudgetsScope](../../models/operations/getexternaluserdefaultbudgetsscope.md)             | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `scopeId`                                                                                                                  | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `scopeOrgId`                                                                                                               | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `owner`                                                                                                                    | [operations.GetExternalUserDefaultBudgetsOwner](../../models/operations/getexternaluserdefaultbudgetsowner.md)             | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `period`                                                                                                                   | [operations.GetExternalUserDefaultBudgetsPeriod](../../models/operations/getexternaluserdefaultbudgetsperiod.md)           | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `limit`                                                                                                                    | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `thresholds`                                                                                                               | [operations.GetExternalUserDefaultBudgetsThresholds](../../models/operations/getexternaluserdefaultbudgetsthresholds.md)[] | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `alertWebhookUrl`                                                                                                          | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |