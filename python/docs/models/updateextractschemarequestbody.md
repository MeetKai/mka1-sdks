# UpdateExtractSchemaRequestBody

Fields to update in the extraction schema. All fields are optional; only provided fields will be updated.


## Fields

| Field                                       | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `name`                                      | *Optional[str]*                             | :heavy_minus_sign:                          | Optional new name for the extraction schema |
| `description`                               | *Optional[str]*                             | :heavy_minus_sign:                          | Optional new description for the schema     |
| `schema_`                                   | Dict[str, *Any*]                            | :heavy_minus_sign:                          | Optional updated JSON Schema definition     |
| `metadata`                                  | Dict[str, *Any*]                            | :heavy_minus_sign:                          | Optional updated metadata                   |