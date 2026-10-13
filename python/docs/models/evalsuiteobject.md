# EvalSuiteObject


## Fields

| Field                          | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `id`                           | *str*                          | :heavy_check_mark:             | N/A                            |
| `object`                       | *Literal["eval.suite"]*        | :heavy_check_mark:             | N/A                            |
| `name`                         | *str*                          | :heavy_check_mark:             | N/A                            |
| `description`                  | *Nullable[str]*                | :heavy_check_mark:             | N/A                            |
| `org_id`                       | *str*                          | :heavy_check_mark:             | The org that owns this suite.  |
| `team_id`                      | *str*                          | :heavy_check_mark:             | The team that owns this suite. |
| `active_version`               | *int*                          | :heavy_check_mark:             | N/A                            |
| `latest_version`               | *int*                          | :heavy_check_mark:             | N/A                            |
| `metadata`                     | Dict[str, *str*]               | :heavy_check_mark:             | N/A                            |
| `created_at`                   | *int*                          | :heavy_check_mark:             | N/A                            |
| `updated_at`                   | *int*                          | :heavy_check_mark:             | N/A                            |