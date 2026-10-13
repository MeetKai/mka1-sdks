# AutoChunkingStrategy

The default chunking strategy. This strategy currently uses a max_chunk_size_tokens of 800 and chunk_overlap_tokens of 400.


## Fields

| Field                                         | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `type`                                        | *Literal["auto"]*                             | :heavy_check_mark:                            | Always 'auto'. The default chunking strategy. |