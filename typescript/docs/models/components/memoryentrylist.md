# MemoryEntryList

## Example Usage

```typescript
import { MemoryEntryList } from "@meetkai/mka1/models/components";

let value: MemoryEntryList = {
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
| `data`                                                             | [components.MemoryEntry](../../models/components/memoryentry.md)[] | :heavy_check_mark:                                                 | N/A                                                                |
| `firstId`                                                          | *string*                                                           | :heavy_check_mark:                                                 | N/A                                                                |
| `lastId`                                                           | *string*                                                           | :heavy_check_mark:                                                 | N/A                                                                |
| `hasMore`                                                          | *boolean*                                                          | :heavy_check_mark:                                                 | N/A                                                                |