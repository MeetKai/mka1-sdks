# CustomToolDefinition

Custom tool definition: Defines a custom tool by name, with optional description and optional output format constraints.


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `type`                                                             | *Literal["custom"]*                                                | :heavy_check_mark:                                                 | N/A                                                                |
| `name`                                                             | *str*                                                              | :heavy_check_mark:                                                 | N/A                                                                |
| `description`                                                      | *Optional[str]*                                                    | :heavy_minus_sign:                                                 | N/A                                                                |
| `format_`                                                          | [Optional[models.CustomToolFormat]](../models/customtoolformat.md) | :heavy_minus_sign:                                                 | N/A                                                                |