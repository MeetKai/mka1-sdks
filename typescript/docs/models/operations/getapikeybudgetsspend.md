# GetApiKeyBudgetsSpend

## Example Usage

```typescript
import { GetApiKeyBudgetsSpend } from "@meetkai/mka1/models/operations";

let value: GetApiKeyBudgetsSpend = {
  window: "<value>",
  costSpent: 216.17,
  limit: 4360.23,
  pct: 585484,
  status: "ok",
};
```

## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `window`                                                                               | *string*                                                                               | :heavy_check_mark:                                                                     | Current period bucket, e.g. 2026-07 / 2026-W28 / 2026-07-07                            |
| `costSpent`                                                                            | *number*                                                                               | :heavy_check_mark:                                                                     | Live spend this window, major currency units                                           |
| `limit`                                                                                | *number*                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `pct`                                                                                  | *number*                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `status`                                                                               | [operations.GetApiKeyBudgetsStatus](../../models/operations/getapikeybudgetsstatus.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |