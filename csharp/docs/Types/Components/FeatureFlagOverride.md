# FeatureFlagOverride


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `Enabled`                                                          | *bool*                                                             | :heavy_check_mark:                                                 | N/A                                                                |
| `Identity`                                                         | *string*                                                           | :heavy_check_mark:                                                 | N/A                                                                |
| `Value`                                                            | *object*                                                           | :heavy_minus_sign:                                                 | Any JSON value; its shape is constrained by the flag's value_type. |