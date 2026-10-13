# MemoryStoreList

## Example Usage

```typescript
import { MemoryStoreList } from "@meetkai/mka1/models/components";

let value: MemoryStoreList = {
  object: "list",
  data: [],
  firstId: "<id>",
  lastId: "<id>",
  hasMore: true,
};
```

## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `object`                                                           | *"list"*                                                           | :heavy_check_mark:                                                 | N/A                                                                |
| `data`                                                             | [components.MemoryStore](../../models/components/memorystore.md)[] | :heavy_check_mark:                                                 | N/A                                                                |
| `firstId`                                                          | *string*                                                           | :heavy_check_mark:                                                 | N/A                                                                |
| `lastId`                                                           | *string*                                                           | :heavy_check_mark:                                                 | N/A                                                                |
| `hasMore`                                                          | *boolean*                                                          | :heavy_check_mark:                                                 | N/A                                                                |