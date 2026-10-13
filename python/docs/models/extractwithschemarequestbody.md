# ExtractWithSchemaRequestBody


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `model`                                                            | *str*                                                              | :heavy_check_mark:                                                 | ID of the model to use for extraction                              |
| `file`                                                             | [models.ExtractWithSchemaFile](../models/extractwithschemafile.md) | :heavy_check_mark:                                                 | The file to extract structured data from                           |
| `prompt`                                                           | *Optional[str]*                                                    | :heavy_minus_sign:                                                 | Optional custom system prompt to guide extraction                  |