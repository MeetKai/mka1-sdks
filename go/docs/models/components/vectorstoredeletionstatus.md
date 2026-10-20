# VectorStoreDeletionStatus

Deletion status for a vector store.


## Fields

| Field                                                    | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ID`                                                     | `string`                                                 | :heavy_check_mark:                                       | The ID of the deleted vector store.                      |
| `Object`                                                 | `string`                                                 | :heavy_check_mark:                                       | The object type, which is always 'vector_store.deleted'. |
| `Deleted`                                                | `bool`                                                   | :heavy_check_mark:                                       | Whether the deletion was successful.                     |