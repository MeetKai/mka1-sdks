# ConversationsItemsDeleteManyRequest

## Example Usage

```typescript
import { ConversationsItemsDeleteManyRequest } from "@meetkai/mka1/models/operations";

let value: ConversationsItemsDeleteManyRequest = {
  conversationId: "conv_abc123",
  requestBody: {
    itemIds: [],
  },
};
```

## Fields

| Field                                                                                                                    | Type                                                                                                                     | Required                                                                                                                 | Description                                                                                                              | Example                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ |
| `conversationId`                                                                                                         | *string*                                                                                                                 | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      | conv_abc123                                                                                                              |
| `xOnBehalfOf`                                                                                                            | *string*                                                                                                                 | :heavy_minus_sign:                                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                                      |                                                                                                                          |
| `requestBody`                                                                                                            | [operations.ConversationsItemsDeleteManyRequestBody](../../models/operations/conversationsitemsdeletemanyrequestbody.md) | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |                                                                                                                          |