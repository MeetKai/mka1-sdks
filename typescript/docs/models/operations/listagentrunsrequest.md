# ListAgentRunsRequest

## Example Usage

```typescript
import { ListAgentRunsRequest } from "@meetkai/mka1/models/operations";

let value: ListAgentRunsRequest = {
  agentId: "<id>",
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `agentId`                                                                                          | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `limit`                                                                                            | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `order`                                                                                            | [operations.ListAgentRunsQueryParamOrder](../../models/operations/listagentrunsqueryparamorder.md) | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `xOnBehalfOf`                                                                                      | *string*                                                                                           | :heavy_minus_sign:                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                |