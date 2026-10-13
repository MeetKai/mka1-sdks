# SetTeamBudgetSpend


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `Window`                                                           | *string*                                                           | :heavy_check_mark:                                                 | Current period bucket, e.g. 2026-07 / 2026-W28 / 2026-07-07        |
| `CostSpent`                                                        | *double*                                                           | :heavy_check_mark:                                                 | Live spend this window, major currency units                       |
| `Limit`                                                            | *double*                                                           | :heavy_check_mark:                                                 | N/A                                                                |
| `Pct`                                                              | *long*                                                             | :heavy_check_mark:                                                 | N/A                                                                |
| `Status`                                                           | [SetTeamBudgetStatus](../../Types/Requests/SetTeamBudgetStatus.md) | :heavy_check_mark:                                                 | N/A                                                                |