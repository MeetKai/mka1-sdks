# ConversationsItemsDeleteRequest

## Example Usage

```typescript
import { ConversationsItemsDeleteRequest } from "@meetkai/mka1/models/operations";

let value: ConversationsItemsDeleteRequest = {
  conversationId: "conv_abc123",
  itemId: "item_abc123",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `conversationId`                                                    | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `itemId`                                                            | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | item_abc123                                                         |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |