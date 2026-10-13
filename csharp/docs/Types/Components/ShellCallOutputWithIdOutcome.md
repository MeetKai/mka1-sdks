# ShellCallOutputWithIdOutcome


## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `Type`                                                                           | [ShellCallOutputWithIdType](../../Types/Components/ShellCallOutputWithIdType.md) | :heavy_check_mark:                                                               | Whether the command exited normally or timed out.                                |
| `ExitCode`                                                                       | *long*                                                                           | :heavy_check_mark:                                                               | Exit code of the command, or null if timed out.                                  |