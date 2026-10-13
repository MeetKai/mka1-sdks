# CreateResponseFeedbackRequest

## Example Usage

```typescript
import { CreateResponseFeedbackRequest } from "@meetkai/mka1/models/operations";

let value: CreateResponseFeedbackRequest = {
  createFeedbackRequest: {
    id: "chatcmpl-abc123def456",
    rating: "thumbs_up",
    description: "The response was accurate and helpful.",
  },
};
```

## Fields

| Field                                                                                                             | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       | Example                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                                     | *string*                                                                                                          | :heavy_minus_sign:                                                                                                | Optional external end-user identifier forwarded by the API gateway.                                               |                                                                                                                   |
| `createFeedbackRequest`                                                                                           | [components.CreateFeedbackRequest](../../models/components/createfeedbackrequest.md)                              | :heavy_check_mark:                                                                                                | N/A                                                                                                               | {<br/>"id": "chatcmpl-abc123def456",<br/>"rating": "thumbs_up",<br/>"description": "The response was accurate and helpful."<br/>} |