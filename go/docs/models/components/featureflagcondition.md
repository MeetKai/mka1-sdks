# FeatureFlagCondition


## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `Operator`                                                                       | [components.FeatureFlagOperator](../../models/components/featureflagoperator.md) | :heavy_check_mark:                                                               | N/A                                                                              |
| `Trait`                                                                          | `string`                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `Value`                                                                          | `any`                                                                            | :heavy_minus_sign:                                                               | Any JSON value; its shape is constrained by the flag's value_type.               |