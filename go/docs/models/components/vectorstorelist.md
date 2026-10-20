# VectorStoreList

A list of vector stores.


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `Object`                                                           | `string`                                                           | :heavy_check_mark:                                                 | The object type, which is always 'list'.                           |
| `Data`                                                             | [][components.VectorStore](../../models/components/vectorstore.md) | :heavy_check_mark:                                                 | Array of vector store objects.                                     |
| `FirstID`                                                          | `string`                                                           | :heavy_check_mark:                                                 | The ID of the first object in the list.                            |
| `LastID`                                                           | `string`                                                           | :heavy_check_mark:                                                 | The ID of the last object in the list.                             |
| `HasMore`                                                          | `bool`                                                             | :heavy_check_mark:                                                 | Whether there are more objects available.                          |