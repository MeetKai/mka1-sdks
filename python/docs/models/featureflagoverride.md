# FeatureFlagOverride


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `enabled`                                                          | *bool*                                                             | :heavy_check_mark:                                                 | N/A                                                                |
| `identity`                                                         | *str*                                                              | :heavy_check_mark:                                                 | N/A                                                                |
| `value`                                                            | *Optional[Any]*                                                    | :heavy_minus_sign:                                                 | Any JSON value; its shape is constrained by the flag's value_type. |