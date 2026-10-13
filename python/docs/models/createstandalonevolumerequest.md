# CreateStandaloneVolumeRequest


## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `idempotency_key`                                                                  | *str*                                                                              | :heavy_check_mark:                                                                 | N/A                                                                                |
| `x_on_behalf_of`                                                                   | *Optional[str]*                                                                    | :heavy_minus_sign:                                                                 | Optional external end-user identifier forwarded by the API gateway.                |
| `body`                                                                             | [models.ComputeStandaloneVolumeCreate](../models/computestandalonevolumecreate.md) | :heavy_check_mark:                                                                 | N/A                                                                                |