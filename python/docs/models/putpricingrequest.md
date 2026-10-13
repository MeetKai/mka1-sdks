# PutPricingRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `idempotency_key`                                                   | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `if_match`                                                          | *str*                                                               | :heavy_check_mark:                                                  | Current pricing version. Use 0 for the first write.                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `body`                                                              | [models.ComputePricingUpdate](../models/computepricingupdate.md)    | :heavy_check_mark:                                                  | N/A                                                                 |