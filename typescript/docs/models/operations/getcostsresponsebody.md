# GetCostsResponseBody

OK

## Example Usage

```typescript
import { GetCostsResponseBody } from "@meetkai/mka1/models/operations";

let value: GetCostsResponseBody = {
  currency: "Argentine Peso",
  startTime: 4873.87,
  endTime: 6607.81,
  groupBy: [
    "<value 1>",
    "<value 2>",
    "<value 3>",
  ],
  data: [
    {
      service: null,
      taskType: "<value>",
      model: "911",
      apiKeyId: "<id>",
      teamId: "<id>",
      userId: "<id>",
      externalUserId: "<id>",
      orgId: "<id>",
      cost: 6101.22,
    },
  ],
  totalCost: 8358.62,
};
```

## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `currency`                                                           | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `startTime`                                                          | *number*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `endTime`                                                            | *number*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `groupBy`                                                            | *string*[]                                                           | :heavy_check_mark:                                                   | N/A                                                                  |
| `data`                                                               | [operations.GetCostsData](../../models/operations/getcostsdata.md)[] | :heavy_check_mark:                                                   | N/A                                                                  |
| `totalCost`                                                          | *number*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |