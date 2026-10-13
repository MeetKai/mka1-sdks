# VectorStoreList

A list of vector stores.


## Fields

| Field                                                | Type                                                 | Required                                             | Description                                          |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `object`                                             | *Literal["list"]*                                    | :heavy_check_mark:                                   | The object type, which is always 'list'.             |
| `data`                                               | List[[models.VectorStore](../models/vectorstore.md)] | :heavy_check_mark:                                   | Array of vector store objects.                       |
| `first_id`                                           | *str*                                                | :heavy_check_mark:                                   | The ID of the first object in the list.              |
| `last_id`                                            | *str*                                                | :heavy_check_mark:                                   | The ID of the last object in the list.               |
| `has_more`                                           | *bool*                                               | :heavy_check_mark:                                   | Whether there are more objects available.            |