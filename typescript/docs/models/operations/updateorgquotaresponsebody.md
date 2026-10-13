# UpdateOrgQuotaResponseBody

OK

## Example Usage

```typescript
import { UpdateOrgQuotaResponseBody } from "@meetkai/mka1/models/operations";

let value: UpdateOrgQuotaResponseBody = {
  id: "<id>",
  quotaEnabled: true,
  quotaPeriod: "month",
  quotaMax: 9297.04,
};
```

## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `id`                                                                                         | *string*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `quotaEnabled`                                                                               | *boolean*                                                                                    | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `quotaPeriod`                                                                                | [operations.UpdateOrgQuotaQuotaPeriod](../../models/operations/updateorgquotaquotaperiod.md) | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `quotaMax`                                                                                   | *number*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |