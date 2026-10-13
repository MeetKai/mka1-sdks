# ListAgentsRequest

## Example Usage

```typescript
import { ListAgentsRequest } from "@meetkai/mka1/models/operations";

let value: ListAgentsRequest = {};
```

## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                | *string*                                                                                     | :heavy_minus_sign:                                                                           | Optional external end-user identifier forwarded by the API gateway.                          |
| `limit`                                                                                      | *number*                                                                                     | :heavy_minus_sign:                                                                           | N/A                                                                                          |
| `order`                                                                                      | [operations.ListAgentsQueryParamOrder](../../models/operations/listagentsqueryparamorder.md) | :heavy_minus_sign:                                                                           | N/A                                                                                          |