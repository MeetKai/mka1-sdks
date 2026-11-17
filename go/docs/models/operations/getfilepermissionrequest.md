# GetFilePermissionRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `FileID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | file-abc123                                                         |
| `UserID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | user_8f2c1                                                          |
| `XOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |