# SetApiKeyBudgetSpend

## Example Usage

```typescript
import { SetApiKeyBudgetSpend } from "@meetkai/mka1/models/operations";

let value: SetApiKeyBudgetSpend = {
  window: "<value>",
  costSpent: 5109.7,
  limit: 5329.17,
  pct: 890010,
  status: "blocked",
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `window`                                                                             | *string*                                                                             | :heavy_check_mark:                                                                   | Current period bucket, e.g. 2026-07 / 2026-W28 / 2026-07-07                          |
| `costSpent`                                                                          | *number*                                                                             | :heavy_check_mark:                                                                   | Live spend this window, major currency units                                         |
| `limit`                                                                              | *number*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `pct`                                                                                | *number*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `status`                                                                             | [operations.SetApiKeyBudgetStatus](../../models/operations/setapikeybudgetstatus.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |