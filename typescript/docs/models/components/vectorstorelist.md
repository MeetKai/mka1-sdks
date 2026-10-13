# VectorStoreList

A list of vector stores.

## Example Usage

```typescript
import { VectorStoreList } from "@meetkai/mka1/models/components";

let value: VectorStoreList = {
  object: "list",
  data: [
    {
      id: "vs_abc123",
      object: "vector_store",
      createdAt: 1704067200,
      name: "Product Documentation",
      usageBytes: 1024000,
      embeddingModel: "auto",
      embeddingDimensions: 1536,
      retrievalMode: "hybrid",
      fileCounts: {
        inProgress: 0,
        completed: 5,
        failed: 0,
        cancelled: 0,
        total: 5,
      },
      status: "completed",
      lastActiveAt: 1704153600,
      metadata: {
        "department": "engineering",
      },
      lastUsedAt: 1704153600,
    },
  ],
  firstId: "<id>",
  lastId: "<id>",
  hasMore: true,
};
```

## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `object`                                                           | *"list"*                                                           | :heavy_check_mark:                                                 | The object type, which is always 'list'.                           |
| `data`                                                             | [components.VectorStore](../../models/components/vectorstore.md)[] | :heavy_check_mark:                                                 | Array of vector store objects.                                     |
| `firstId`                                                          | *string*                                                           | :heavy_check_mark:                                                 | The ID of the first object in the list.                            |
| `lastId`                                                           | *string*                                                           | :heavy_check_mark:                                                 | The ID of the last object in the list.                             |
| `hasMore`                                                          | *boolean*                                                          | :heavy_check_mark:                                                 | Whether there are more objects available.                          |