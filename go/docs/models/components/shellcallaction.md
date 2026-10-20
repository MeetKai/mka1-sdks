# ShellCallAction


## Fields

| Field                            | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `Type`                           | `string`                         | :heavy_check_mark:               | N/A                              |
| `Command`                        | `*string`                        | :heavy_minus_sign:               | Shell command to execute.        |
| `TimeoutMs`                      | `*int64`                         | :heavy_minus_sign:               | Command timeout in milliseconds. |
| `MaxOutputLength`                | `*int64`                         | :heavy_minus_sign:               | Maximum output characters.       |