# CreateScopedApiKeyRequestBody


## Fields

| Field                                            | Type                                             | Required                                         | Description                                      |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| `Name`                                           | *string*                                         | :heavy_check_mark:                               | N/A                                              |
| `TeamId`                                         | *string*                                         | :heavy_check_mark:                               | N/A                                              |
| `Scopes`                                         | List<*string*>                                   | :heavy_check_mark:                               | N/A                                              |
| `ExpiresIn`                                      | *long*                                           | :heavy_minus_sign:                               | N/A                                              |
| `RateLimitEnabled`                               | *bool*                                           | :heavy_minus_sign:                               | N/A                                              |
| `RateLimitTimeWindow`                            | *double*                                         | :heavy_minus_sign:                               | N/A                                              |
| `RateLimitMax`                                   | *double*                                         | :heavy_minus_sign:                               | N/A                                              |
| `OnBehalfOf`                                     | [OnBehalfOf](../../Types/Requests/OnBehalfOf.md) | :heavy_minus_sign:                               | N/A                                              |