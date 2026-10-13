# GetUserBudgetsSpend

## Example Usage

```typescript
import { GetUserBudgetsSpend } from "@meetkai/mka1/models/operations";

let value: GetUserBudgetsSpend = {
  window: "<value>",
  costSpent: 3124.67,
  limit: 8949.44,
  pct: 645177,
  status: "ok",
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `window`                                                                           | *string*                                                                           | :heavy_check_mark:                                                                 | Current period bucket, e.g. 2026-07 / 2026-W28 / 2026-07-07                        |
| `costSpent`                                                                        | *number*                                                                           | :heavy_check_mark:                                                                 | Live spend this window, major currency units                                       |
| `limit`                                                                            | *number*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `pct`                                                                              | *number*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `status`                                                                           | [operations.GetUserBudgetsStatus](../../models/operations/getuserbudgetsstatus.md) | :heavy_check_mark:                                                                 | N/A                                                                                |