# FileCitation

Annotation for citing a specific file in the model's output. Used when the model references information from a file.


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `type`                                                              | *Literal["file_citation"]*                                          | :heavy_check_mark:                                                  | The annotation type identifier for file citations.                  |
| `file_id`                                                           | *str*                                                               | :heavy_check_mark:                                                  | The ID of the file being cited.                                     |
| `filename`                                                          | *str*                                                               | :heavy_check_mark:                                                  | The name of the file being cited.                                   |
| `index`                                                             | *int*                                                               | :heavy_check_mark:                                                  | The character index in the output text where this citation applies. |