# CreateScopedAPIKeyRequestBody


## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `name`                                                 | *str*                                                  | :heavy_check_mark:                                     | N/A                                                    |
| `team_id`                                              | *str*                                                  | :heavy_check_mark:                                     | N/A                                                    |
| `scopes`                                               | List[*str*]                                            | :heavy_check_mark:                                     | N/A                                                    |
| `expires_in`                                           | *Optional[int]*                                        | :heavy_minus_sign:                                     | N/A                                                    |
| `rate_limit_enabled`                                   | *Optional[bool]*                                       | :heavy_minus_sign:                                     | N/A                                                    |
| `rate_limit_time_window`                               | *Optional[float]*                                      | :heavy_minus_sign:                                     | N/A                                                    |
| `rate_limit_max`                                       | *Optional[float]*                                      | :heavy_minus_sign:                                     | N/A                                                    |
| `on_behalf_of`                                         | [Optional[models.OnBehalfOf]](../models/onbehalfof.md) | :heavy_minus_sign:                                     | N/A                                                    |