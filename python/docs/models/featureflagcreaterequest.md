# FeatureFlagCreateRequest


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `default_value`                                                    | *Any*                                                              | :heavy_check_mark:                                                 | Any JSON value; its shape is constrained by the flag's value_type. |
| `description`                                                      | *Optional[str]*                                                    | :heavy_minus_sign:                                                 | N/A                                                                |
| `key`                                                              | *str*                                                              | :heavy_check_mark:                                                 | N/A                                                                |
| `name`                                                             | *str*                                                              | :heavy_check_mark:                                                 | N/A                                                                |
| `project_id`                                                       | *Optional[str]*                                                    | :heavy_minus_sign:                                                 | Project to assign. Defaults to the Default project.                |
| `value_type`                                                       | [models.FeatureFlagValueType](../models/featureflagvaluetype.md)   | :heavy_check_mark:                                                 | N/A                                                                |