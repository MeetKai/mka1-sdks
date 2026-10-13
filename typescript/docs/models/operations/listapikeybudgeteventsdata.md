# ListApiKeyBudgetEventsData

## Example Usage

```typescript
import { ListApiKeyBudgetEventsData } from "@meetkai/mka1/models/operations";

let value: ListApiKeyBudgetEventsData = {
  id: "<id>",
  budgetId: "<id>",
  type: "threshold_alert",
  pct: 6333.21,
  periodKey: "<value>",
  targetId: "<id>",
  spendSnapshot: 3865.08,
  limitSnapshot: 3598.33,
  createdAt: "1726029933780",
};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `id`                                                                                           | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `budgetId`                                                                                     | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `type`                                                                                         | [operations.ListApiKeyBudgetEventsType](../../models/operations/listapikeybudgeteventstype.md) | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `pct`                                                                                          | *number*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `periodKey`                                                                                    | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `targetId`                                                                                     | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `spendSnapshot`                                                                                | *number*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `limitSnapshot`                                                                                | *number*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `createdAt`                                                                                    | *string*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |