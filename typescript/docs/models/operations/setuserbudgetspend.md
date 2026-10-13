# SetUserBudgetSpend

## Example Usage

```typescript
import { SetUserBudgetSpend } from "@meetkai/mka1/models/operations";

let value: SetUserBudgetSpend = {
  window: "<value>",
  costSpent: 3384.45,
  limit: 4843.36,
  pct: 182486,
  status: "blocked",
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `window`                                                                         | *string*                                                                         | :heavy_check_mark:                                                               | Current period bucket, e.g. 2026-07 / 2026-W28 / 2026-07-07                      |
| `costSpent`                                                                      | *number*                                                                         | :heavy_check_mark:                                                               | Live spend this window, major currency units                                     |
| `limit`                                                                          | *number*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `pct`                                                                            | *number*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `status`                                                                         | [operations.SetUserBudgetStatus](../../models/operations/setuserbudgetstatus.md) | :heavy_check_mark:                                                               | N/A                                                                              |