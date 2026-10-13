# FilePath

Annotation for referencing a file path in the model's output. Used when the model mentions specific files.


## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `type`                                                                         | *Literal["file_path"]*                                                         | :heavy_check_mark:                                                             | The annotation type identifier for file path references.                       |
| `file_id`                                                                      | *str*                                                                          | :heavy_check_mark:                                                             | The ID of the file being referenced.                                           |
| `index`                                                                        | *int*                                                                          | :heavy_check_mark:                                                             | The character index in the output text where this file path reference applies. |