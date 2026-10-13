# GetOrgBudgetsSpend

## Example Usage

```typescript
import { GetOrgBudgetsSpend } from "@meetkai/mka1/models/operations";

let value: GetOrgBudgetsSpend = {
  window: "<value>",
  costSpent: 7546.19,
  limit: 6272.26,
  pct: 312701,
  status: "ok",
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `window`                                                                         | *string*                                                                         | :heavy_check_mark:                                                               | Current period bucket, e.g. 2026-07 / 2026-W28 / 2026-07-07                      |
| `costSpent`                                                                      | *number*                                                                         | :heavy_check_mark:                                                               | Live spend this window, major currency units                                     |
| `limit`                                                                          | *number*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `pct`                                                                            | *number*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `status`                                                                         | [operations.GetOrgBudgetsStatus](../../models/operations/getorgbudgetsstatus.md) | :heavy_check_mark:                                                               | N/A                                                                              |