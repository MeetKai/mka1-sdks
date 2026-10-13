# CreateJobRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `IdempotencyKey`                                                    | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `Body`                                                              | [ComputeJobCreate](../../Types/Components/ComputeJobCreate.md)      | :heavy_check_mark:                                                  | N/A                                                                 |