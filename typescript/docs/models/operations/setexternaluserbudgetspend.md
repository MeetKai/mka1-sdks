# SetExternalUserBudgetSpend

## Example Usage

```typescript
import { SetExternalUserBudgetSpend } from "@meetkai/mka1/models/operations";

let value: SetExternalUserBudgetSpend = {
  window: "<value>",
  costSpent: 6799.23,
  limit: 5697.86,
  pct: 89436,
  status: "ok",
};
```

## Fields

| Field                                                                                            | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `window`                                                                                         | *string*                                                                                         | :heavy_check_mark:                                                                               | Current period bucket, e.g. 2026-07 / 2026-W28 / 2026-07-07                                      |
| `costSpent`                                                                                      | *number*                                                                                         | :heavy_check_mark:                                                                               | Live spend this window, major currency units                                                     |
| `limit`                                                                                          | *number*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `pct`                                                                                            | *number*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `status`                                                                                         | [operations.SetExternalUserBudgetStatus](../../models/operations/setexternaluserbudgetstatus.md) | :heavy_check_mark:                                                                               | N/A                                                                                              |