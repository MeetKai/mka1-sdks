# EmbeddingModelLimits

Limits for the embedding model


## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `max_batch_size`                                                 | *float*                                                          | :heavy_check_mark:                                               | Maximum number of inputs allowed in a single batch request       |
| `max_input_tokens`                                               | *float*                                                          | :heavy_check_mark:                                               | Maximum tokens per individual input (derived from contextWindow) |
| `max_input_length`                                               | *float*                                                          | :heavy_check_mark:                                               | Maximum characters per individual input (contextWindow * 2)      |