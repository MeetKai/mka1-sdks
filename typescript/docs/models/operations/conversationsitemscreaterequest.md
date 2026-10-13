# ConversationsItemsCreateRequest

## Example Usage

```typescript
import { ConversationsItemsCreateRequest } from "@meetkai/mka1/models/operations";

let value: ConversationsItemsCreateRequest = {
  conversationId: "conv_abc123",
  createItemsRequest: {
    items: [
      {
        role: "user",
        content: "What is the weather today?",
      },
    ],
  },
};
```

## Fields

| Field                                                                                           | Type                                                                                            | Required                                                                                        | Description                                                                                     | Example                                                                                         |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `conversationId`                                                                                | *string*                                                                                        | :heavy_check_mark:                                                                              | N/A                                                                                             | conv_abc123                                                                                     |
| `xOnBehalfOf`                                                                                   | *string*                                                                                        | :heavy_minus_sign:                                                                              | Optional external end-user identifier forwarded by the API gateway.                             |                                                                                                 |
| `createItemsRequest`                                                                            | [components.CreateItemsRequest](../../models/components/createitemsrequest.md)                  | :heavy_check_mark:                                                                              | N/A                                                                                             | {<br/>"items": [<br/>{<br/>"type": "message",<br/>"role": "user",<br/>"content": "What is the weather today?"<br/>}<br/>]<br/>} |