# TrackingRunsGetMetricHistoryRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `RunID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `MetricKey`                                                         | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `MaxResults`                                                        | `*int64`                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `PageToken`                                                         | `*string`                                                           | :heavy_minus_sign:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |