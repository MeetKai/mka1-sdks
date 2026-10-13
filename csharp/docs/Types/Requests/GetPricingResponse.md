# GetPricingResponse


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `HttpMeta`                                                                  | [HTTPMetadata](../../Types/Components/HTTPMetadata.md)                      | :heavy_check_mark:                                                          | N/A                                                                         |
| `ComputePricing`                                                            | [Types.Components.ComputePricing](../../Types/Components/ComputePricing.md) | :heavy_minus_sign:                                                          | Latest immutable public storage price                                       |
| `ComputeErrorEnvelope`                                                      | [ComputeErrorEnvelope](../../Types/Components/ComputeErrorEnvelope.md)      | :heavy_minus_sign:                                                          | API error                                                                   |
| `Headers`                                                                   | Dictionary<String, List<*string*>>                                          | :heavy_check_mark:                                                          | N/A                                                                         |