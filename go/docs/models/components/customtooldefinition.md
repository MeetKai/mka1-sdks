# CustomToolDefinition

Custom tool definition: Defines a custom tool by name, with optional description and optional output format constraints.


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `Type`                                                                      | `string`                                                                    | :heavy_check_mark:                                                          | N/A                                                                         |
| `Name`                                                                      | `string`                                                                    | :heavy_check_mark:                                                          | N/A                                                                         |
| `Description`                                                               | `*string`                                                                   | :heavy_minus_sign:                                                          | N/A                                                                         |
| `Format`                                                                    | [*components.CustomToolFormat](../../models/components/customtoolformat.md) | :heavy_minus_sign:                                                          | N/A                                                                         |