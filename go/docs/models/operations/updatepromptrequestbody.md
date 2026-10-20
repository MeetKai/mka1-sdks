# UpdatePromptRequestBody


## Fields

| Field                                       | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `Name`                                      | `*string`                                   | :heavy_minus_sign:                          | Updated prompt name                         |
| `Description`                               | optionalnullable.OptionalNullable[`string`] | :heavy_minus_sign:                          | Updated description — pass null to clear    |
| `Metadata`                                  | map[string]`any`                            | :heavy_minus_sign:                          | Updated metadata — replaces existing        |