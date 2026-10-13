# VectorStoreFileDeletionStatus

Deletion status for a vector store file.


## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `Id`                                                          | *string*                                                      | :heavy_check_mark:                                            | The ID of the deleted file.                                   |
| `Object`                                                      | *string*                                                      | :heavy_check_mark:                                            | The object type, which is always 'vector_store.file.deleted'. |
| `Deleted`                                                     | *bool*                                                        | :heavy_check_mark:                                            | Whether the deletion was successful.                          |