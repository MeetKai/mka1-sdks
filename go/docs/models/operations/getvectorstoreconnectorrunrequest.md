# GetVectorStoreConnectorRunRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ConnectorID`                                                       | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `RunID`                                                             | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `ItemsLimit`                                                        | `*int64`                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `ItemsAfter`                                                        | `*string`                                                           | :heavy_minus_sign:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |