# EmbeddingsResponseData


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `object`                                                                      | *Optional[Literal["embedding"]]*                                              | :heavy_minus_sign:                                                            | N/A                                                                           |
| `embedding`                                                                   | [models.Embedding](../models/embedding.md)                                    | :heavy_check_mark:                                                            | The embedding vector, either as an array of floats or a base64-encoded string |
| `index`                                                                       | *float*                                                                       | :heavy_check_mark:                                                            | N/A                                                                           |