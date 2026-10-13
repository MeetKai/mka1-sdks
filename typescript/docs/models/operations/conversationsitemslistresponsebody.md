# ConversationsItemsListResponseBody

OK

## Example Usage

```typescript
import { ConversationsItemsListResponseBody } from "@meetkai/mka1/models/operations";

let value: ConversationsItemsListResponseBody = {
  data: [
    {
      role: "user",
      content: "Hello, how are you?",
      id: "item_abc123",
    },
  ],
  hasMore: false,
  lastId: "item_abc123",
};
```

## Fields

| Field                                   | Type                                    | Required                                | Description                             |
| --------------------------------------- | --------------------------------------- | --------------------------------------- | --------------------------------------- |
| `object`                                | *"list"*                                | :heavy_minus_sign:                      | N/A                                     |
| `data`                                  | *operations.Data*[]                     | :heavy_check_mark:                      | A list of conversation items.           |
| `hasMore`                               | *boolean*                               | :heavy_check_mark:                      | Whether there are more items            |
| `lastId`                                | *string*                                | :heavy_check_mark:                      | ID of the last item in the current page |