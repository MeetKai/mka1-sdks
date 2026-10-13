# CancelBatchRequest

## Example Usage

```typescript
import { CancelBatchRequest } from "@meetkai/mka1/models/operations";

let value: CancelBatchRequest = {
  batchId: "batch_aa87e2b1112a455b8deabed784372198",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `batchId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | batch_aa87e2b1112a455b8deabed784372198                              |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |