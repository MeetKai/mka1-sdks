# DeleteRepoRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Org`                                                               | `string`                                                            | :heavy_check_mark:                                                  | The organization URL slug.                                          |
| `Name`                                                              | `string`                                                            | :heavy_check_mark:                                                  | The repository name (URL label).                                    |
| `XOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |