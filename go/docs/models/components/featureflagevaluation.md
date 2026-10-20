# FeatureFlagEvaluation


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `Enabled`                                                          | `bool`                                                             | :heavy_check_mark:                                                 | N/A                                                                |
| `Reason`                                                           | `string`                                                           | :heavy_check_mark:                                                 | disabled, override, rule:<index>, rollout, or default              |
| `Value`                                                            | `any`                                                              | :heavy_check_mark:                                                 | Any JSON value; its shape is constrained by the flag's value_type. |