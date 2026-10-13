# ListAgentVersionsRequest

## Example Usage

```typescript
import { ListAgentVersionsRequest } from "@meetkai/mka1/models/operations";

let value: ListAgentVersionsRequest = {
  agentId: "<id>",
};
```

## Fields

| Field                                                                                                      | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `agentId`                                                                                                  | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `limit`                                                                                                    | *number*                                                                                                   | :heavy_minus_sign:                                                                                         | N/A                                                                                                        |
| `order`                                                                                                    | [operations.ListAgentVersionsQueryParamOrder](../../models/operations/listagentversionsqueryparamorder.md) | :heavy_minus_sign:                                                                                         | N/A                                                                                                        |
| `xOnBehalfOf`                                                                                              | *string*                                                                                                   | :heavy_minus_sign:                                                                                         | Optional external end-user identifier forwarded by the API gateway.                                        |