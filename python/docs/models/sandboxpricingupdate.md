# SandboxPricingUpdate

Full-replace rate card update.

A SKU that has a price and is omitted here would become unpriced, and its
usage would then be recorded with no cost, which can never be billed. That
is refused unless ``allow_unpriced`` says it is intended.


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `rates`                                                             | Dict[str, [models.SandboxPriceRate](../models/sandboxpricerate.md)] | :heavy_check_mark:                                                  | N/A                                                                 |
| `currency`                                                          | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 |
| `allow_unpriced`                                                    | *Optional[bool]*                                                    | :heavy_minus_sign:                                                  | N/A                                                                 |