# ConversationDeletedObject

## Example Usage

```typescript
import { ConversationDeletedObject } from "@meetkai/mka1/models/components";

let value: ConversationDeletedObject = {
  id: "conv_abc123",
  object: "conversation.deleted",
  deleted: true,
};
```

## Fields

| Field                              | Type                               | Required                           | Description                        |
| ---------------------------------- | ---------------------------------- | ---------------------------------- | ---------------------------------- |
| `id`                               | *string*                           | :heavy_check_mark:                 | The ID of the deleted conversation |
| `object`                           | *"conversation.deleted"*           | :heavy_check_mark:                 | N/A                                |
| `deleted`                          | *boolean*                          | :heavy_check_mark:                 | Always true                        |