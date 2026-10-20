# ListPromptsRequest


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `Limit`                                                                     | `*int64`                                                                    | :heavy_minus_sign:                                                          | N/A                                                                         |
| `After`                                                                     | `*string`                                                                   | :heavy_minus_sign:                                                          | N/A                                                                         |
| `Order`                                                                     | [*operations.ListPromptsOrder](../../models/operations/listpromptsorder.md) | :heavy_minus_sign:                                                          | Sort order by creation date                                                 |
| `XOnBehalfOf`                                                               | `*string`                                                                   | :heavy_minus_sign:                                                          | Optional external end-user identifier forwarded by the API gateway.         |