# SandboxPricingUpdate

Full-replace rate card update.

A SKU that has a price and is omitted here would become unpriced, and its
usage would then be recorded with no cost, which can never be billed. That
is refused unless ``allow_unpriced`` says it is intended.


## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `Rates`                                                                            | Dictionary<String, [SandboxPriceRate](../../Types/Components/SandboxPriceRate.md)> | :heavy_check_mark:                                                                 | N/A                                                                                |
| `Currency`                                                                         | *string*                                                                           | :heavy_minus_sign:                                                                 | N/A                                                                                |
| `AllowUnpriced`                                                                    | *bool*                                                                             | :heavy_minus_sign:                                                                 | N/A                                                                                |