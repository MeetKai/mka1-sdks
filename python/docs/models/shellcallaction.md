# ShellCallAction


## Fields

| Field                            | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `type`                           | *Literal["exec"]*                | :heavy_check_mark:               | N/A                              |
| `command`                        | *Optional[str]*                  | :heavy_minus_sign:               | Shell command to execute.        |
| `timeout_ms`                     | *Optional[int]*                  | :heavy_minus_sign:               | Command timeout in milliseconds. |
| `max_output_length`              | *Optional[int]*                  | :heavy_minus_sign:               | Maximum output characters.       |