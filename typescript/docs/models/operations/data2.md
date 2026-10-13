# Data2

## Example Usage

```typescript
import { Data2 } from "@meetkai/mka1/models/operations";

let value: Data2 = {
  id: "<id>",
  scope: "apikey",
  scopeId: "<id>",
  scopeOrgId: "<id>",
  owner: "org",
  period: "monthly",
  limit: 1091.83,
  thresholds: [],
  alertWebhookUrl: "https://miserly-forage.biz",
};
```

## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `id`                                                                     | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `scope`                                                                  | [operations.DataScope](../../models/operations/datascope.md)             | :heavy_check_mark:                                                       | N/A                                                                      |
| `scopeId`                                                                | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `scopeOrgId`                                                             | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `owner`                                                                  | [operations.DataOwner](../../models/operations/dataowner.md)             | :heavy_check_mark:                                                       | N/A                                                                      |
| `period`                                                                 | [operations.DataPeriod](../../models/operations/dataperiod.md)           | :heavy_check_mark:                                                       | N/A                                                                      |
| `limit`                                                                  | *number*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `thresholds`                                                             | [operations.DataThresholds](../../models/operations/datathresholds.md)[] | :heavy_check_mark:                                                       | N/A                                                                      |
| `alertWebhookUrl`                                                        | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |