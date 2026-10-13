# Connection


## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `github_login`                                                       | *str*                                                                | :heavy_check_mark:                                                   | N/A                                                                  |
| `github_user_id`                                                     | *int*                                                                | :heavy_check_mark:                                                   | N/A                                                                  |
| `scopes`                                                             | *str*                                                                | :heavy_check_mark:                                                   | N/A                                                                  |
| `synced_at`                                                          | [date](https://docs.python.org/3/library/datetime.html#date-objects) | :heavy_check_mark:                                                   | N/A                                                                  |
| `token_invalid_at`                                                   | [date](https://docs.python.org/3/library/datetime.html#date-objects) | :heavy_minus_sign:                                                   | N/A                                                                  |
| `repositories`                                                       | List[[models.ConnectedRepository](../models/connectedrepository.md)] | :heavy_check_mark:                                                   | N/A                                                                  |