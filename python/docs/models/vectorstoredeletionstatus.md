# VectorStoreDeletionStatus

Deletion status for a vector store.


## Fields

| Field                                                    | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `id`                                                     | *str*                                                    | :heavy_check_mark:                                       | The ID of the deleted vector store.                      |
| `object`                                                 | *Literal["vector_store.deleted"]*                        | :heavy_check_mark:                                       | The object type, which is always 'vector_store.deleted'. |
| `deleted`                                                | *bool*                                                   | :heavy_check_mark:                                       | Whether the deletion was successful.                     |