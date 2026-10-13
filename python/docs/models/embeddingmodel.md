# EmbeddingModel

Information about an embedding model and its limits


## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `id`                                                             | *str*                                                            | :heavy_check_mark:                                               | Qualified model identifier in provider:model format              |
| `provider`                                                       | *str*                                                            | :heavy_check_mark:                                               | Provider identifier (e.g., 'meetkai')                            |
| `model`                                                          | *str*                                                            | :heavy_check_mark:                                               | Model identifier within the provider                             |
| `limits`                                                         | [models.EmbeddingModelLimits](../models/embeddingmodellimits.md) | :heavy_check_mark:                                               | Limits for the embedding model                                   |