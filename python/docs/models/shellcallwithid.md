# ShellCallWithID

Shell call item: A hosted-container shell execution request with a command and status.


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `type`                                                             | *Literal["shell_call"]*                                            | :heavy_check_mark:                                                 | N/A                                                                |
| `id`                                                               | *str*                                                              | :heavy_check_mark:                                                 | The unique ID of the message.                                      |
| `call_id`                                                          | *str*                                                              | :heavy_check_mark:                                                 | N/A                                                                |
| `action`                                                           | [models.ShellCallAction](../models/shellcallaction.md)             | :heavy_check_mark:                                                 | N/A                                                                |
| `status`                                                           | [models.ShellCallWithIDStatus](../models/shellcallwithidstatus.md) | :heavy_check_mark:                                                 | N/A                                                                |
| `response_id`                                                      | *OptionalNullable[str]*                                            | :heavy_minus_sign:                                                 | The ID of the response that created this item, if any.             |
| `metadata`                                                         | Dict[str, *str*]                                                   | :heavy_minus_sign:                                                 | Metadata from the response that created this item, if any.         |