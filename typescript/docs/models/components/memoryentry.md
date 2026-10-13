# MemoryEntry

## Example Usage

```typescript
import { MemoryEntry } from "@meetkai/mka1/models/components";

let value: MemoryEntry = {
  id: "<id>",
  object: "memory_entry",
  memoryStoreId: "<id>",
  path: "/srv",
  content: "<value>",
  contentHash: "<value>",
  bytes: 761951,
  createdAt: 7717.77,
  updatedAt: 3251.39,
};
```

## Fields

| Field                    | Type                     | Required                 | Description              |
| ------------------------ | ------------------------ | ------------------------ | ------------------------ |
| `id`                     | *string*                 | :heavy_check_mark:       | N/A                      |
| `object`                 | *"memory_entry"*         | :heavy_check_mark:       | N/A                      |
| `memoryStoreId`          | *string*                 | :heavy_check_mark:       | N/A                      |
| `path`                   | *string*                 | :heavy_check_mark:       | N/A                      |
| `content`                | *string*                 | :heavy_check_mark:       | N/A                      |
| `contentHash`            | *string*                 | :heavy_check_mark:       | N/A                      |
| `bytes`                  | *number*                 | :heavy_check_mark:       | N/A                      |
| `metadata`               | Record<string, *string*> | :heavy_minus_sign:       | N/A                      |
| `createdAt`              | *number*                 | :heavy_check_mark:       | N/A                      |
| `updatedAt`              | *number*                 | :heavy_check_mark:       | N/A                      |