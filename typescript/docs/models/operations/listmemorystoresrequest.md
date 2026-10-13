# ListMemoryStoresRequest

## Example Usage

```typescript
import { ListMemoryStoresRequest } from "@meetkai/mka1/models/operations";

let value: ListMemoryStoresRequest = {};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `limit`                                                                                                  | *number*                                                                                                 | :heavy_minus_sign:                                                                                       | N/A                                                                                                      |
| `order`                                                                                                  | [operations.ListMemoryStoresQueryParamOrder](../../models/operations/listmemorystoresqueryparamorder.md) | :heavy_minus_sign:                                                                                       | N/A                                                                                                      |
| `after`                                                                                                  | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | N/A                                                                                                      |
| `xOnBehalfOf`                                                                                            | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                      |