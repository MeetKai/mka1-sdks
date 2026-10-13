# FeatureFlagStateInput


## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `enabled`                                                            | *bool*                                                               | :heavy_check_mark:                                                   | N/A                                                                  |
| `overrides`                                                          | List[[models.FeatureFlagOverride](../models/featureflagoverride.md)] | :heavy_check_mark:                                                   | N/A                                                                  |
| `rollout_percentage`                                                 | *int*                                                                | :heavy_check_mark:                                                   | N/A                                                                  |
| `rules`                                                              | List[[models.FeatureFlagRule](../models/featureflagrule.md)]         | :heavy_check_mark:                                                   | N/A                                                                  |
| `value`                                                              | *Any*                                                                | :heavy_check_mark:                                                   | Any JSON value; its shape is constrained by the flag's value_type.   |