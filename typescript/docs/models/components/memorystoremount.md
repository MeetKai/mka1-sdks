# MemoryStoreMount

## Example Usage

```typescript
import { MemoryStoreMount } from "@meetkai/mka1/models/components";

let value: MemoryStoreMount = {
  storeId: "<id>",
  label: "<value>",
};
```

## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `storeId`                                                              | *string*                                                               | :heavy_check_mark:                                                     | ID of the memory store to mount into the container.                    |
| `label`                                                                | *string*                                                               | :heavy_check_mark:                                                     | Directory name for this store under /mnt/memory.                       |
| `access`                                                               | [components.Access](../../models/components/access.md)                 | :heavy_minus_sign:                                                     | Whether the mounted memory store can be modified.                      |
| `description`                                                          | *string*                                                               | :heavy_minus_sign:                                                     | Optional short description of the store for agent context.             |
| `instructions`                                                         | *string*                                                               | :heavy_minus_sign:                                                     | Optional instructions for how the agent should use this mounted store. |