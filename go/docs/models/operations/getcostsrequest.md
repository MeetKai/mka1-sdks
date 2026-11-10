# GetCostsRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `StartTime`                                                         | `int64`                                                             | :heavy_check_mark:                                                  | N/A                                                                 |
| `EndTime`                                                           | `int64`                                                             | :heavy_check_mark:                                                  | N/A                                                                 |
| `GroupBy`                                                           | `*string`                                                           | :heavy_minus_sign:                                                  | N/A                                                                 |
| `OrgID`                                                             | `*string`                                                           | :heavy_minus_sign:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |