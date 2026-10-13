# FeatureFlagRule


## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `conditions`                                                           | List[[models.FeatureFlagCondition](../models/featureflagcondition.md)] | :heavy_check_mark:                                                     | N/A                                                                    |
| `description`                                                          | *Optional[str]*                                                        | :heavy_minus_sign:                                                     | N/A                                                                    |
| `enabled`                                                              | *bool*                                                                 | :heavy_check_mark:                                                     | N/A                                                                    |
| `rollout_percentage`                                                   | *Optional[int]*                                                        | :heavy_minus_sign:                                                     | N/A                                                                    |
| `value`                                                                | *Optional[Any]*                                                        | :heavy_minus_sign:                                                     | Any JSON value; its shape is constrained by the flag's value_type.     |