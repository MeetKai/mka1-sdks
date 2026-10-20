# CreateScopedAPIKeyRequestBody


## Fields

| Field                                                           | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `Name`                                                          | `string`                                                        | :heavy_check_mark:                                              | N/A                                                             |
| `TeamID`                                                        | `string`                                                        | :heavy_check_mark:                                              | N/A                                                             |
| `Scopes`                                                        | []`string`                                                      | :heavy_check_mark:                                              | N/A                                                             |
| `ExpiresIn`                                                     | `*int64`                                                        | :heavy_minus_sign:                                              | N/A                                                             |
| `RateLimitEnabled`                                              | `*bool`                                                         | :heavy_minus_sign:                                              | N/A                                                             |
| `RateLimitTimeWindow`                                           | `*float64`                                                      | :heavy_minus_sign:                                              | N/A                                                             |
| `RateLimitMax`                                                  | `*float64`                                                      | :heavy_minus_sign:                                              | N/A                                                             |
| `OnBehalfOf`                                                    | [*operations.OnBehalfOf](../../models/operations/onbehalfof.md) | :heavy_minus_sign:                                              | N/A                                                             |