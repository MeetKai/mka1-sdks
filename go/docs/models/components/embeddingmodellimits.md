# EmbeddingModelLimits

Limits for the embedding model


## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `MaxBatchSize`                                                   | `float64`                                                        | :heavy_check_mark:                                               | Maximum number of inputs allowed in a single batch request       |
| `MaxInputTokens`                                                 | `float64`                                                        | :heavy_check_mark:                                               | Maximum tokens per individual input (derived from contextWindow) |
| `MaxInputLength`                                                 | `float64`                                                        | :heavy_check_mark:                                               | Maximum characters per individual input (contextWindow * 2)      |