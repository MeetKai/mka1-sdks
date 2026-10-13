# FeatureFlagCreateRequest


## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `DefaultValue`                                                         | *object*                                                               | :heavy_check_mark:                                                     | Any JSON value; its shape is constrained by the flag's value_type.     |
| `Description`                                                          | *string*                                                               | :heavy_minus_sign:                                                     | N/A                                                                    |
| `Key`                                                                  | *string*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `Name`                                                                 | *string*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `ProjectId`                                                            | *string*                                                               | :heavy_minus_sign:                                                     | Project to assign. Defaults to the Default project.                    |
| `ValueType`                                                            | [FeatureFlagValueType](../../Types/Components/FeatureFlagValueType.md) | :heavy_check_mark:                                                     | N/A                                                                    |