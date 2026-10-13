# ConversationsItemsListRequest

## Example Usage

```typescript
import { ConversationsItemsListRequest } from "@meetkai/mka1/models/operations";

let value: ConversationsItemsListRequest = {
  conversationId: "conv_abc123",
  after: "item_abc123",
  include: [
    "content",
    "metadata",
  ],
  limit: 50,
  order: "desc",
};
```

## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              | Example                                                                  |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `conversationId`                                                         | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      | conv_abc123                                                              |
| `after`                                                                  | *string*                                                                 | :heavy_minus_sign:                                                       | N/A                                                                      | item_abc123                                                              |
| `include`                                                                | *string*[]                                                               | :heavy_minus_sign:                                                       | N/A                                                                      | [<br/>"content",<br/>"metadata"<br/>]                                    |
| `limit`                                                                  | *number*                                                                 | :heavy_minus_sign:                                                       | N/A                                                                      | 50                                                                       |
| `order`                                                                  | [operations.QueryParamOrder](../../models/operations/queryparamorder.md) | :heavy_minus_sign:                                                       | The order to return the input items in. Default is `asc`.                | desc                                                                     |
| `xOnBehalfOf`                                                            | *string*                                                                 | :heavy_minus_sign:                                                       | Optional external end-user identifier forwarded by the API gateway.      |                                                                          |