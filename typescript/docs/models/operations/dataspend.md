# DataSpend

## Example Usage

```typescript
import { DataSpend } from "@meetkai/mka1/models/operations";

let value: DataSpend = {
  window: "<value>",
  costSpent: 5770.32,
  limit: 4268.12,
  pct: 362929,
  status: "ok",
};
```

## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `window`                                                       | *string*                                                       | :heavy_check_mark:                                             | Current period bucket, e.g. 2026-07 / 2026-W28 / 2026-07-07    |
| `costSpent`                                                    | *number*                                                       | :heavy_check_mark:                                             | Live spend this window, major currency units                   |
| `limit`                                                        | *number*                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `pct`                                                          | *number*                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `status`                                                       | [operations.DataStatus](../../models/operations/datastatus.md) | :heavy_check_mark:                                             | N/A                                                            |