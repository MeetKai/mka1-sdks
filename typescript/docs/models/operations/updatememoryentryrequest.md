# UpdateMemoryEntryRequest

## Example Usage

```typescript
import { UpdateMemoryEntryRequest } from "@meetkai/mka1/models/operations";

let value: UpdateMemoryEntryRequest = {
  memoryStoreId: "mem_aa87e2b1112a455b8deabed784372198",
  entryId: "mem_entry_bb98f3c2223b566c9dfbcef895483209",
  updateMemoryEntryRequest: {
    content: "<value>",
  },
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                | Example                                                                                    |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `memoryStoreId`                                                                            | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        | mem_aa87e2b1112a455b8deabed784372198                                                       |
| `entryId`                                                                                  | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        | mem_entry_bb98f3c2223b566c9dfbcef895483209                                                 |
| `xOnBehalfOf`                                                                              | *string*                                                                                   | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |                                                                                            |
| `updateMemoryEntryRequest`                                                                 | [components.UpdateMemoryEntryRequest](../../models/components/updatememoryentryrequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |                                                                                            |