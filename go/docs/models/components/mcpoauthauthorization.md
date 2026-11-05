# McpOAuthAuthorization


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `Object`                                                                | `string`                                                                | :heavy_check_mark:                                                      | N/A                                                                     |
| `ServerID`                                                              | `string`                                                                | :heavy_check_mark:                                                      | N/A                                                                     |
| `AuthorizationURL`                                                      | `string`                                                                | :heavy_check_mark:                                                      | Open this URL in the end user's browser. It carries a single-use state. |
| `ExpiresAt`                                                             | [time.Time](https://pkg.go.dev/time#Time)                               | :heavy_check_mark:                                                      | The authorization must be completed before this time.                   |