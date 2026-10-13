# GetOrgQuotaResponseBody

OK

## Example Usage

```typescript
import { GetOrgQuotaResponseBody } from "@meetkai/mka1/models/operations";

let value: GetOrgQuotaResponseBody = {
  id: "<id>",
  quotaEnabled: true,
  quotaPeriod: "month",
  quotaMax: 1547.25,
};
```

## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `id`                                                                                   | *string*                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `quotaEnabled`                                                                         | *boolean*                                                                              | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `quotaPeriod`                                                                          | [operations.GetOrgQuotaQuotaPeriod](../../models/operations/getorgquotaquotaperiod.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `quotaMax`                                                                             | *number*                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    |