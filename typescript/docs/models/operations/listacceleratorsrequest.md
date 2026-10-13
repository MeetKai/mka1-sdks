# ListAcceleratorsRequest

## Example Usage

```typescript
import { ListAcceleratorsRequest } from "@meetkai/mka1/models/operations";

let value: ListAcceleratorsRequest = {};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `vendor`                                                            | [operations.Vendor](../../models/operations/vendor.md)              | :heavy_minus_sign:                                                  | N/A                                                                 |
| `cursor`                                                            | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `limit`                                                             | *number*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |