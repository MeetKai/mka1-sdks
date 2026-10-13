# FileWithMetadata

A file with optional per-file metadata and chunking strategy.


## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `file_id`                                                                                          | *str*                                                                                              | :heavy_check_mark:                                                                                 | A File ID that the vector store should use.                                                        |
| `attributes`                                                                                       | Dict[str, [models.FileWithMetadataAttributes](../models/filewithmetadataattributes.md)]            | :heavy_minus_sign:                                                                                 | Optional attributes for this specific file.                                                        |
| `chunking_strategy`                                                                                | [Optional[models.FileWithMetadataChunkingStrategy]](../models/filewithmetadatachunkingstrategy.md) | :heavy_minus_sign:                                                                                 | Optional chunking strategy for this specific file.                                                 |