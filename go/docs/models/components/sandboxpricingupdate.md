# SandboxPricingUpdate

Full-replace rate card update.

A SKU that has a price and is omitted here would become unpriced, and its
usage would then be recorded with no cost, which can never be billed. That
is refused unless ``allow_unpriced`` says it is intended.


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Rates`                                                                               | map[string][components.SandboxPriceRate](../../models/components/sandboxpricerate.md) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `Currency`                                                                            | optionalnullable.OptionalNullable[`string`]                                           | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `AllowUnpriced`                                                                       | `*bool`                                                                               | :heavy_minus_sign:                                                                    | N/A                                                                                   |