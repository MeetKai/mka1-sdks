# EmbeddingModelListResponse

Response containing available embedding models and their limits


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `object`                                                   | *Optional[Literal["list"]]*                                | :heavy_minus_sign:                                         | N/A                                                        |
| `data`                                                     | List[[models.EmbeddingModel](../models/embeddingmodel.md)] | :heavy_check_mark:                                         | List of available embedding models with their limits       |