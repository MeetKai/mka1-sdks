# LocalShellCall

Local shell call item: A local-shell execution request with command details and execution status.


## Fields

| Field                                                    | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `type`                                                   | *Literal["local_shell_call"]*                            | :heavy_check_mark:                                       | N/A                                                      |
| `id`                                                     | *str*                                                    | :heavy_check_mark:                                       | N/A                                                      |
| `call_id`                                                | *str*                                                    | :heavy_check_mark:                                       | N/A                                                      |
| `action`                                                 | [models.LocalShellAction](../models/localshellaction.md) | :heavy_check_mark:                                       | N/A                                                      |
| `status`                                                 | *str*                                                    | :heavy_check_mark:                                       | N/A                                                      |