# LocalShellCallWithID

Local shell call item: A local-shell execution request with command details and execution status.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `type`                                                     | *Literal["local_shell_call"]*                              | :heavy_check_mark:                                         | N/A                                                        |
| `id`                                                       | *str*                                                      | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `call_id`                                                  | *str*                                                      | :heavy_check_mark:                                         | N/A                                                        |
| `action`                                                   | [models.LocalShellAction](../models/localshellaction.md)   | :heavy_check_mark:                                         | N/A                                                        |
| `status`                                                   | *str*                                                      | :heavy_check_mark:                                         | N/A                                                        |
| `response_id`                                              | *OptionalNullable[str]*                                    | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `metadata`                                                 | Dict[str, *str*]                                           | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |