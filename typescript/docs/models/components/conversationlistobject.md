# ConversationListObject

## Example Usage

```typescript
import { ConversationListObject } from "@meetkai/mka1/models/components";

let value: ConversationListObject = {
  object: "list",
  data: [
    {
      id: "conv_abc123",
      object: "conversation",
      createdAt: 1704067200,
      metadata: {
        "session_id": "abc123",
      },
      deletedAt: 8686.74,
    },
  ],
  hasMore: true,
  lastId: "conv_abc123",
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `object`                                                                         | *"list"*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `data`                                                                           | [components.ConversationObject](../../models/components/conversationobject.md)[] | :heavy_check_mark:                                                               | Array of conversations                                                           |
| `hasMore`                                                                        | *boolean*                                                                        | :heavy_check_mark:                                                               | Whether there are more conversations                                             |
| `lastId`                                                                         | *string*                                                                         | :heavy_minus_sign:                                                               | ID of the last conversation in the current page                                  |