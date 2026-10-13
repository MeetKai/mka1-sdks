# EvaluateFeatureFlagsRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `env`                                                               | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `identity`                                                          | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Stable identifier of the caller; enables rollouts and overrides.    |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |