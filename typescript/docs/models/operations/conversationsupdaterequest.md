# ConversationsUpdateRequest

## Example Usage

```typescript
import { ConversationsUpdateRequest } from "@meetkai/mka1/models/operations";

let value: ConversationsUpdateRequest = {
  conversationId: "conv_abc123",
  update: {
    metadata: {},
  },
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `conversationId`                                                    | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | conv_abc123                                                         |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `update`                                                            | [components.Update](../../models/components/update.md)              | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |