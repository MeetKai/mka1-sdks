# ComputeProviderQuote


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `available`                                                                   | *bool*                                                                        | :heavy_check_mark:                                                            | N/A                                                                           |
| `price_usd_hr`                                                                | [Nullable[models.ComputePriceRange]](../models/computepricerange.md)          | :heavy_check_mark:                                                            | N/A                                                                           |
| `provider`                                                                    | *str*                                                                         | :heavy_check_mark:                                                            | Opaque compute-provider identifier. Supported values are deployment-specific. |