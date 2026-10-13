# RunCommandRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id_param`                                                  | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `body`                                                              | [models.CommandRequest](../models/commandrequest.md)                | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |