# UpdateExtractSchemaRequestBody

Fields to update in the extraction schema. All fields are optional; only provided fields will be updated.


## Fields

| Field                                       | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `Name`                                      | `*string`                                   | :heavy_minus_sign:                          | Optional new name for the extraction schema |
| `Description`                               | `*string`                                   | :heavy_minus_sign:                          | Optional new description for the schema     |
| `Schema`                                    | map[string]`any`                            | :heavy_minus_sign:                          | Optional updated JSON Schema definition     |
| `Metadata`                                  | map[string]`any`                            | :heavy_minus_sign:                          | Optional updated metadata                   |