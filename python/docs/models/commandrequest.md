# CommandRequest


## Fields

| Field                   | Type                    | Required                | Description             |
| ----------------------- | ----------------------- | ----------------------- | ----------------------- |
| `session_id`            | *str*                   | :heavy_check_mark:      | N/A                     |
| `session_token`         | *OptionalNullable[str]* | :heavy_minus_sign:      | N/A                     |
| `command_request_id`    | *OptionalNullable[str]* | :heavy_minus_sign:      | N/A                     |
| `command`               | *str*                   | :heavy_check_mark:      | N/A                     |
| `args`                  | List[*str*]             | :heavy_minus_sign:      | N/A                     |
| `cwd`                   | *OptionalNullable[str]* | :heavy_minus_sign:      | N/A                     |
| `env`                   | Dict[str, *str*]        | :heavy_minus_sign:      | N/A                     |
| `timeout_seconds`       | *Optional[int]*         | :heavy_minus_sign:      | N/A                     |