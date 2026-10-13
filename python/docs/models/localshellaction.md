# LocalShellAction


## Fields

| Field               | Type                | Required            | Description         |
| ------------------- | ------------------- | ------------------- | ------------------- |
| `type`              | *Literal["exec"]*   | :heavy_check_mark:  | N/A                 |
| `command`           | List[*str*]         | :heavy_check_mark:  | N/A                 |
| `env`               | Dict[str, *str*]    | :heavy_check_mark:  | N/A                 |
| `timeout_ms`        | *Optional[int]*     | :heavy_minus_sign:  | N/A                 |
| `user`              | *Optional[str]*     | :heavy_minus_sign:  | N/A                 |
| `working_directory` | *Optional[str]*     | :heavy_minus_sign:  | N/A                 |