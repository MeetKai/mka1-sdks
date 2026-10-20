# ExtractWithSchemaRequestBody


## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `Model`                                                                              | `string`                                                                             | :heavy_check_mark:                                                                   | ID of the model to use for extraction                                                |
| `File`                                                                               | [operations.ExtractWithSchemaFile](../../models/operations/extractwithschemafile.md) | :heavy_check_mark:                                                                   | The file to extract structured data from                                             |
| `Prompt`                                                                             | `*string`                                                                            | :heavy_minus_sign:                                                                   | Optional custom system prompt to guide extraction                                    |