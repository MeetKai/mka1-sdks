# VectorStoreFileList

A list of vector store files.

## Example Usage

```typescript
import { VectorStoreFileList } from "@meetkai/mka1/models/components";

let value: VectorStoreFileList = {
  object: "list",
  data: [
    {
      id: "<id>",
      object: "vector_store.file",
      usageBytes: 911720,
      createdAt: 477527,
      vectorStoreId: "<id>",
      status: "completed",
      lastError: {
        code: "server_error",
        message: "<value>",
      },
    },
  ],
  firstId: "<id>",
  lastId: "<id>",
  hasMore: false,
};
```

## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `object`                                                                   | *"list"*                                                                   | :heavy_check_mark:                                                         | The object type, which is always 'list'.                                   |
| `data`                                                                     | [components.VectorStoreFile](../../models/components/vectorstorefile.md)[] | :heavy_check_mark:                                                         | Array of vector store file objects.                                        |
| `firstId`                                                                  | *string*                                                                   | :heavy_check_mark:                                                         | The ID of the first object in the list.                                    |
| `lastId`                                                                   | *string*                                                                   | :heavy_check_mark:                                                         | The ID of the last object in the list.                                     |
| `hasMore`                                                                  | *boolean*                                                                  | :heavy_check_mark:                                                         | Whether there are more objects available.                                  |