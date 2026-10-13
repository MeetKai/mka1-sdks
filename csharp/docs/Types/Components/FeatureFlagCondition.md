# FeatureFlagCondition


## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `Operator`                                                           | [FeatureFlagOperator](../../Types/Components/FeatureFlagOperator.md) | :heavy_check_mark:                                                   | N/A                                                                  |
| `Trait`                                                              | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `Value`                                                              | *object*                                                             | :heavy_minus_sign:                                                   | Any JSON value; its shape is constrained by the flag's value_type.   |