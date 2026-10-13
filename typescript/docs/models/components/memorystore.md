# MemoryStore

## Example Usage

```typescript
import { MemoryStore } from "@meetkai/mka1/models/components";

let value: MemoryStore = {
  id: "<id>",
  object: "memory_store",
  name: "<value>",
  description: "how deform sweetly vague more",
  instructions: "<value>",
  visibility: "workspace",
  createdAt: 7191.79,
  updatedAt: 173.08,
  deletedAt: null,
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `id`                                                                                 | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `object`                                                                             | *"memory_store"*                                                                     | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `name`                                                                               | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `description`                                                                        | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `instructions`                                                                       | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `visibility`                                                                         | [components.MemoryStoreVisibility](../../models/components/memorystorevisibility.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `metadata`                                                                           | Record<string, *string*>                                                             | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `createdAt`                                                                          | *number*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `updatedAt`                                                                          | *number*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `deletedAt`                                                                          | *number*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |