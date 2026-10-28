# OpenAPIOperationRequestBody

JSON request body. Other media types (forms, multipart, binary) are not supported.


## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `Required`                                                     | `*bool`                                                        | :heavy_minus_sign:                                             | N/A                                                            |
| `Description`                                                  | `*string`                                                      | :heavy_minus_sign:                                             | N/A                                                            |
| `ContentType`                                                  | `*string`                                                      | :heavy_minus_sign:                                             | N/A                                                            |
| `Schema`                                                       | map[string]`any`                                               | :heavy_minus_sign:                                             | JSON Schema for the value. References must already be inlined. |