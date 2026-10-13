# EmbeddingModelLimits

Limits for the embedding model


## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `MaxBatchSize`                                                   | *double*                                                         | :heavy_check_mark:                                               | Maximum number of inputs allowed in a single batch request       |
| `MaxInputTokens`                                                 | *double*                                                         | :heavy_check_mark:                                               | Maximum tokens per individual input (derived from contextWindow) |
| `MaxInputLength`                                                 | *double*                                                         | :heavy_check_mark:                                               | Maximum characters per individual input (contextWindow * 2)      |