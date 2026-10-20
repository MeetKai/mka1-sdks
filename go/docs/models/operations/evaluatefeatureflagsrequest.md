# EvaluateFeatureFlagsRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Env`                                                               | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `Identity`                                                          | `*string`                                                           | :heavy_minus_sign:                                                  | Stable identifier of the caller; enables rollouts and overrides.    |
| `XOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |