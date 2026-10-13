# GetTeamBudgetsSpend

## Example Usage

```typescript
import { GetTeamBudgetsSpend } from "@meetkai/mka1/models/operations";

let value: GetTeamBudgetsSpend = {
  window: "<value>",
  costSpent: 1104.54,
  limit: 1038.5,
  pct: 123549,
  status: "blocked",
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `window`                                                                           | *string*                                                                           | :heavy_check_mark:                                                                 | Current period bucket, e.g. 2026-07 / 2026-W28 / 2026-07-07                        |
| `costSpent`                                                                        | *number*                                                                           | :heavy_check_mark:                                                                 | Live spend this window, major currency units                                       |
| `limit`                                                                            | *number*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `pct`                                                                              | *number*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `status`                                                                           | [operations.GetTeamBudgetsStatus](../../models/operations/getteambudgetsstatus.md) | :heavy_check_mark:                                                                 | N/A                                                                                |