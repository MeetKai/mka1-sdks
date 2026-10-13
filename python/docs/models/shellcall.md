# ShellCall

Shell call item: A hosted-container shell execution request with a command and status.


## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `type`                                                 | *Literal["shell_call"]*                                | :heavy_check_mark:                                     | N/A                                                    |
| `id`                                                   | *str*                                                  | :heavy_check_mark:                                     | N/A                                                    |
| `call_id`                                              | *str*                                                  | :heavy_check_mark:                                     | N/A                                                    |
| `action`                                               | [models.ShellCallAction](../models/shellcallaction.md) | :heavy_check_mark:                                     | N/A                                                    |
| `status`                                               | [models.ShellCallStatus](../models/shellcallstatus.md) | :heavy_check_mark:                                     | N/A                                                    |