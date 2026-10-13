# CodeRequest


## Fields

| Field                                                    | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `session_id`                                             | *str*                                                    | :heavy_check_mark:                                       | N/A                                                      |
| `session_token`                                          | *OptionalNullable[str]*                                  | :heavy_minus_sign:                                       | N/A                                                      |
| `runtime`                                                | [Optional[models.CodeRuntime]](../models/coderuntime.md) | :heavy_minus_sign:                                       | N/A                                                      |
| `code`                                                   | *str*                                                    | :heavy_check_mark:                                       | N/A                                                      |
| `cwd`                                                    | *OptionalNullable[str]*                                  | :heavy_minus_sign:                                       | N/A                                                      |
| `env`                                                    | Dict[str, *str*]                                         | :heavy_minus_sign:                                       | N/A                                                      |
| `timeout_seconds`                                        | *Optional[int]*                                          | :heavy_minus_sign:                                       | N/A                                                      |