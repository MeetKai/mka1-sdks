# RunCodeRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SessionID`                                                         | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `XOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `Body`                                                              | [components.CodeRequest](../../models/components/coderequest.md)    | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |