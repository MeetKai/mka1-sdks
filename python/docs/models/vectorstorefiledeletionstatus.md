# VectorStoreFileDeletionStatus

Deletion status for a vector store file.


## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `id`                                                          | *str*                                                         | :heavy_check_mark:                                            | The ID of the deleted file.                                   |
| `object`                                                      | *Literal["vector_store.file.deleted"]*                        | :heavy_check_mark:                                            | The object type, which is always 'vector_store.file.deleted'. |
| `deleted`                                                     | *bool*                                                        | :heavy_check_mark:                                            | Whether the deletion was successful.                          |