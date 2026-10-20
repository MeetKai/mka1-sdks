# ShellCallOutputWithIDOutcome


## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `Type`                                                                                       | [components.ShellCallOutputWithIDType](../../models/components/shellcalloutputwithidtype.md) | :heavy_check_mark:                                                                           | Whether the command exited normally or timed out.                                            |
| `ExitCode`                                                                                   | `*int64`                                                                                     | :heavy_check_mark:                                                                           | Exit code of the command, or null if timed out.                                              |