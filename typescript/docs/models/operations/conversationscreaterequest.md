# ConversationsCreateRequest

## Example Usage

```typescript
import { ConversationsCreateRequest } from "@meetkai/mka1/models/operations";

let value: ConversationsCreateRequest = {
  createConversationRequest: {
    metadata: {
      "session_id": "abc123",
      "user_type": "premium",
    },
  },
};
```

## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  | Example                                                                                      |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                | *string*                                                                                     | :heavy_minus_sign:                                                                           | Optional external end-user identifier forwarded by the API gateway.                          |                                                                                              |
| `createConversationRequest`                                                                  | [components.CreateConversationRequest](../../models/components/createconversationrequest.md) | :heavy_check_mark:                                                                           | N/A                                                                                          | {<br/>"metadata": {<br/>"session_id": "abc123",<br/>"user_type": "premium"<br/>}<br/>}       |