# VectorStoreDeletionStatus

Deletion status for a vector store.

## Example Usage

```typescript
import { VectorStoreDeletionStatus } from "@meetkai/mka1/models/components";

let value: VectorStoreDeletionStatus = {
  id: "<id>",
  object: "vector_store.deleted",
  deleted: true,
};
```

## Fields

| Field                                                    | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `id`                                                     | *string*                                                 | :heavy_check_mark:                                       | The ID of the deleted vector store.                      |
| `object`                                                 | *"vector_store.deleted"*                                 | :heavy_check_mark:                                       | The object type, which is always 'vector_store.deleted'. |
| `deleted`                                                | *boolean*                                                | :heavy_check_mark:                                       | Whether the deletion was successful.                     |