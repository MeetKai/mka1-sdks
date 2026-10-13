# DeleteRepoTagRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org`                                                               | *str*                                                               | :heavy_check_mark:                                                  | The organization URL slug.                                          |
| `name`                                                              | *str*                                                               | :heavy_check_mark:                                                  | The repository name (URL label).                                    |
| `tag`                                                               | *str*                                                               | :heavy_check_mark:                                                  | The image tag, exactly as pushed (tags are case-sensitive).         |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |