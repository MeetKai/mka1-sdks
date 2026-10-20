# EmbeddingModel

Information about an embedding model and its limits


## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `ID`                                                                               | `string`                                                                           | :heavy_check_mark:                                                                 | Qualified model identifier in provider:model format                                |
| `Provider`                                                                         | `string`                                                                           | :heavy_check_mark:                                                                 | Provider identifier (e.g., 'meetkai')                                              |
| `Model`                                                                            | `string`                                                                           | :heavy_check_mark:                                                                 | Model identifier within the provider                                               |
| `Limits`                                                                           | [components.EmbeddingModelLimits](../../models/components/embeddingmodellimits.md) | :heavy_check_mark:                                                                 | Limits for the embedding model                                                     |