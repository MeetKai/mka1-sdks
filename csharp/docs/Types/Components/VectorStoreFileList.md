# VectorStoreFileList

A list of vector store files.


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `Object`                                                           | *string*                                                           | :heavy_check_mark:                                                 | The object type, which is always 'list'.                           |
| `Data`                                                             | List<[VectorStoreFile](../../Types/Components/VectorStoreFile.md)> | :heavy_check_mark:                                                 | Array of vector store file objects.                                |
| `FirstId`                                                          | *string*                                                           | :heavy_check_mark:                                                 | The ID of the first object in the list.                            |
| `LastId`                                                           | *string*                                                           | :heavy_check_mark:                                                 | The ID of the last object in the list.                             |
| `HasMore`                                                          | *bool*                                                             | :heavy_check_mark:                                                 | Whether there are more objects available.                          |