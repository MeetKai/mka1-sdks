# QuoteGeneratorAPIV1DatasetsGeneratorsGeneratorIDQuotePostRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `GeneratorID`                                                       | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `Body`                                                              | [components.QuoteRequest](../../models/components/quoterequest.md)  | :heavy_check_mark:                                                  | N/A                                                                 |