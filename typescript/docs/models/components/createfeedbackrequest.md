# CreateFeedbackRequest

Request parameters for creating feedback. Allows users to rate and comment on model outputs.

## Example Usage

```typescript
import { CreateFeedbackRequest } from "@meetkai/mka1/models/components";

let value: CreateFeedbackRequest = {
  id: "chatcmpl-abc123def456",
  rating: "thumbs_up",
  description: "The response was accurate and helpful.",
};
```

## Fields

| Field                                                                                                                                    | Type                                                                                                                                     | Required                                                                                                                                 | Description                                                                                                                              |
| ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                                     | *string*                                                                                                                                 | :heavy_check_mark:                                                                                                                       | Request ID to associate this feedback with. Use chat completion request ID or response ID.                                               |
| `rating`                                                                                                                                 | [components.Rating](../../models/components/rating.md)                                                                                   | :heavy_minus_sign:                                                                                                                       | Optional feedback rating. Can be 'thumbs_up' for positive feedback or 'thumbs_down' for negative feedback.                               |
| `description`                                                                                                                            | *string*                                                                                                                                 | :heavy_minus_sign:                                                                                                                       | Optional detailed feedback description. Use this to provide specific comments, suggestions, or explain the rating (max 2000 characters). |