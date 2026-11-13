# ListVectorStoreConnectorsStatic


## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `ChunkOverlapTokens`                                                                | `int64`                                                                             | :heavy_check_mark:                                                                  | Tokens shared by consecutive chunks. Must not exceed half of max_chunk_size_tokens. |
| `MaxChunkSizeTokens`                                                                | `int64`                                                                             | :heavy_check_mark:                                                                  | The maximum number of tokens in each chunk.                                         |