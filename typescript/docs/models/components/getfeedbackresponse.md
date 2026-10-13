# GetFeedbackResponse

Response containing the feedback entry for the requested resource.

## Example Usage

```typescript
import { GetFeedbackResponse } from "@meetkai/mka1/models/components";

let value: GetFeedbackResponse = {
  id: "<id>",
};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                     | *string*                                                                                                 | :heavy_check_mark:                                                                                       | The request ID that this feedback is associated with                                                     |
| `rating`                                                                                                 | [components.GetFeedbackResponseRating](../../models/components/getfeedbackresponserating.md)             | :heavy_minus_sign:                                                                                       | The feedback rating indicating user satisfaction                                                         |
| `description`                                                                                            | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | Optional detailed feedback description providing additional context or explanation (max 2000 characters) |
| `createdAt`                                                                                              | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)            | :heavy_minus_sign:                                                                                       | ISO 8601 timestamp when the underlying output was created                                                |
| `updatedAt`                                                                                              | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)            | :heavy_minus_sign:                                                                                       | ISO 8601 timestamp when the underlying output record was last updated                                    |