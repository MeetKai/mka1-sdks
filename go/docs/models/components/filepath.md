# FilePath

Annotation for referencing a file path in the model's output. Used when the model mentions specific files.


## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `Type`                                                                         | `string`                                                                       | :heavy_check_mark:                                                             | The annotation type identifier for file path references.                       |
| `FileID`                                                                       | `string`                                                                       | :heavy_check_mark:                                                             | The ID of the file being referenced.                                           |
| `Index`                                                                        | `int64`                                                                        | :heavy_check_mark:                                                             | The character index in the output text where this file path reference applies. |