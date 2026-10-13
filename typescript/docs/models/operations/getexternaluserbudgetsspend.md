# GetExternalUserBudgetsSpend

## Example Usage

```typescript
import { GetExternalUserBudgetsSpend } from "@meetkai/mka1/models/operations";

let value: GetExternalUserBudgetsSpend = {
  window: "<value>",
  costSpent: 376.16,
  limit: 622.68,
  pct: 891639,
  status: "blocked",
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `window`                                                                                           | *string*                                                                                           | :heavy_check_mark:                                                                                 | Current period bucket, e.g. 2026-07 / 2026-W28 / 2026-07-07                                        |
| `costSpent`                                                                                        | *number*                                                                                           | :heavy_check_mark:                                                                                 | Live spend this window, major currency units                                                       |
| `limit`                                                                                            | *number*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `pct`                                                                                              | *number*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `status`                                                                                           | [operations.GetExternalUserBudgetsStatus](../../models/operations/getexternaluserbudgetsstatus.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |