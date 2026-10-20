# JSONSchema

JSON Schema definition for structured output. Required when type is 'json_schema'.


## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `Name`                                                                       | `string`                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `Description`                                                                | `*string`                                                                    | :heavy_minus_sign:                                                           | What the response format is for, used by the model to decide how to respond. |
| `Schema`                                                                     | map[string]`any`                                                             | :heavy_check_mark:                                                           | N/A                                                                          |
| `Strict`                                                                     | `*bool`                                                                      | :heavy_minus_sign:                                                           | N/A                                                                          |