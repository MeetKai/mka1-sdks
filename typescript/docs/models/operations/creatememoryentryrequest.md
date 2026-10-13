# CreateMemoryEntryRequest

## Example Usage

```typescript
import { CreateMemoryEntryRequest } from "@meetkai/mka1/models/operations";

let value: CreateMemoryEntryRequest = {
  memoryStoreId: "mem_aa87e2b1112a455b8deabed784372198",
  createMemoryEntryRequest: {
    path: "/usr/ports",
    content: "<value>",
  },
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                | Example                                                                                    |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `memoryStoreId`                                                                            | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        | mem_aa87e2b1112a455b8deabed784372198                                                       |
| `xOnBehalfOf`                                                                              | *string*                                                                                   | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |                                                                                            |
| `createMemoryEntryRequest`                                                                 | [components.CreateMemoryEntryRequest](../../models/components/creatememoryentryrequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |                                                                                            |