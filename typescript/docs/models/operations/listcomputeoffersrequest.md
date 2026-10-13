# ListComputeOffersRequest

## Example Usage

```typescript
import { ListComputeOffersRequest } from "@meetkai/mka1/models/operations";

let value: ListComputeOffersRequest = {};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `accelerator`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `gpuCount`                                                          | *number*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `interconnect`                                                      | [operations.Interconnect](../../models/operations/interconnect.md)  | :heavy_minus_sign:                                                  | N/A                                                                 |
| `provider`                                                          | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `region`                                                            | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `available`                                                         | *boolean*                                                           | :heavy_minus_sign:                                                  | N/A                                                                 |
| `cursor`                                                            | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `limit`                                                             | *number*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |