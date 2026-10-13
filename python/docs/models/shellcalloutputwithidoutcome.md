# ShellCallOutputWithIDOutcome


## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `type`                                                                     | [models.ShellCallOutputWithIDType](../models/shellcalloutputwithidtype.md) | :heavy_check_mark:                                                         | Whether the command exited normally or timed out.                          |
| `exit_code`                                                                | *Nullable[int]*                                                            | :heavy_check_mark:                                                         | Exit code of the command, or null if timed out.                            |