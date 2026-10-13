# UpdateMemoryStoreRequest

## Example Usage

```typescript
import { UpdateMemoryStoreRequest } from "@meetkai/mka1/models/operations";

let value: UpdateMemoryStoreRequest = {
  memoryStoreId: "mem_aa87e2b1112a455b8deabed784372198",
  updateMemoryStoreRequest: {},
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                | Example                                                                                    |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `memoryStoreId`                                                                            | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        | mem_aa87e2b1112a455b8deabed784372198                                                       |
| `xOnBehalfOf`                                                                              | *string*                                                                                   | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |                                                                                            |
| `updateMemoryStoreRequest`                                                                 | [components.UpdateMemoryStoreRequest](../../models/components/updatememorystorerequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |                                                                                            |