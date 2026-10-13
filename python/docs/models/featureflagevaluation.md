# FeatureFlagEvaluation


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `enabled`                                                          | *bool*                                                             | :heavy_check_mark:                                                 | N/A                                                                |
| `reason`                                                           | *str*                                                              | :heavy_check_mark:                                                 | disabled, override, rule:<index>, rollout, or default              |
| `value`                                                            | *Any*                                                              | :heavy_check_mark:                                                 | Any JSON value; its shape is constrained by the flag's value_type. |