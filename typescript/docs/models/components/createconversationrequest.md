# CreateConversationRequest

## Example Usage

```typescript
import { CreateConversationRequest } from "@meetkai/mka1/models/components";

let value: CreateConversationRequest = {
  metadata: {
    "session_id": "abc123",
    "user_type": "premium",
  },
};
```

## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `items`                                                                       | *components.Item*[]                                                           | :heavy_minus_sign:                                                            | Initial items to include in the conversation context. Max 20 items at a time. |
| `metadata`                                                                    | Record<string, *string*>                                                      | :heavy_minus_sign:                                                            | Set of 16 key-value pairs for storing additional information.                 |