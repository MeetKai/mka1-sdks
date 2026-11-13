# BrowseVectorStoreConnectorRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ConnectorID`                                                       | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `Path`                                                              | `*string`                                                           | :heavy_minus_sign:                                                  | N/A                                                                 |
| `Limit`                                                             | `*int64`                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `Cursor`                                                            | `*string`                                                           | :heavy_minus_sign:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |