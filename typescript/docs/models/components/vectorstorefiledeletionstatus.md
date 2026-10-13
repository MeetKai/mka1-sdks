# VectorStoreFileDeletionStatus

Deletion status for a vector store file.

## Example Usage

```typescript
import { VectorStoreFileDeletionStatus } from "@meetkai/mka1/models/components";

let value: VectorStoreFileDeletionStatus = {
  id: "<id>",
  object: "vector_store.file.deleted",
  deleted: false,
};
```

## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `id`                                                          | *string*                                                      | :heavy_check_mark:                                            | The ID of the deleted file.                                   |
| `object`                                                      | *"vector_store.file.deleted"*                                 | :heavy_check_mark:                                            | The object type, which is always 'vector_store.file.deleted'. |
| `deleted`                                                     | *boolean*                                                     | :heavy_check_mark:                                            | Whether the deletion was successful.                          |