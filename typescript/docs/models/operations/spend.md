# Spend

## Example Usage

```typescript
import { Spend } from "@meetkai/mka1/models/operations";

let value: Spend = {
  window: "<value>",
  costSpent: 4275.86,
  limit: 8538.54,
  pct: 283481,
  status: "ok",
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `window`                                                                       | *string*                                                                       | :heavy_check_mark:                                                             | Current period bucket, e.g. 2026-07 / 2026-W28 / 2026-07-07                    |
| `costSpent`                                                                    | *number*                                                                       | :heavy_check_mark:                                                             | Live spend this window, major currency units                                   |
| `limit`                                                                        | *number*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `pct`                                                                          | *number*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `status`                                                                       | [operations.SetOrgBudgetStatus](../../models/operations/setorgbudgetstatus.md) | :heavy_check_mark:                                                             | N/A                                                                            |