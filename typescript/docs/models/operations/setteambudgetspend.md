# SetTeamBudgetSpend

## Example Usage

```typescript
import { SetTeamBudgetSpend } from "@meetkai/mka1/models/operations";

let value: SetTeamBudgetSpend = {
  window: "<value>",
  costSpent: 6914.4,
  limit: 7609.77,
  pct: 620538,
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
| `status`                                                                         | [operations.SetTeamBudgetStatus](../../models/operations/setteambudgetstatus.md) | :heavy_check_mark:                                                               | N/A                                                                              |