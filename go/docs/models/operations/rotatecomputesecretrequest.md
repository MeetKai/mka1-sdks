# RotateComputeSecretRequest


## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `ID`                                                                             | `string`                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `XOnBehalfOf`                                                                    | `*string`                                                                        | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |
| `Body`                                                                           | [components.ComputeSecretRotate](../../models/components/computesecretrotate.md) | :heavy_check_mark:                                                               | N/A                                                                              |