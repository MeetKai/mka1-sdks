# Environment1

## Example Usage

```typescript
import { Environment1 } from "@meetkai/mka1/models/components";

let value: Environment1 = {
  type: "container_auto",
};
```

## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `type`                                                               | *"container_auto"*                                                   | :heavy_check_mark:                                                   | N/A                                                                  |
| `networkPolicy`                                                      | *any*                                                                | :heavy_minus_sign:                                                   | Arbitrary JSON value.                                                |
| `skills`                                                             | *any*[]                                                              | :heavy_minus_sign:                                                   | N/A                                                                  |
| `memoryStores`                                                       | [components.MemoryStores](../../models/components/memorystores.md)[] | :heavy_minus_sign:                                                   | N/A                                                                  |