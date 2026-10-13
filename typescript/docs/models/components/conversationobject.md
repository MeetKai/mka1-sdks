# ConversationObject

## Example Usage

```typescript
import { ConversationObject } from "@meetkai/mka1/models/components";

let value: ConversationObject = {
  id: "conv_abc123",
  object: "conversation",
  createdAt: 1704067200,
  metadata: {
    "session_id": "abc123",
    "user_type": "premium",
  },
  deletedAt: null,
};
```

## Fields

| Field                                                                                                             | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                              | *string*                                                                                                          | :heavy_check_mark:                                                                                                | The unique ID of the conversation                                                                                 |
| `object`                                                                                                          | *"conversation"*                                                                                                  | :heavy_check_mark:                                                                                                | The object type, always 'conversation'                                                                            |
| `createdAt`                                                                                                       | *number*                                                                                                          | :heavy_check_mark:                                                                                                | Unix timestamp of when the conversation was created                                                               |
| `metadata`                                                                                                        | Record<string, *string*>                                                                                          | :heavy_minus_sign:                                                                                                | Set of 16 key-value pairs. Keys max 64 chars, values max 512 chars.                                               |
| `identity`                                                                                                        | *string*                                                                                                          | :heavy_minus_sign:                                                                                                | Identity of the conversation owner. Either a SHA256 hash or raw userId:externalUserId depending on IDENTITY_MODE. |
| `deletedAt`                                                                                                       | *number*                                                                                                          | :heavy_check_mark:                                                                                                | Unix timestamp of when the conversation was soft-deleted, or null if not deleted.                                 |