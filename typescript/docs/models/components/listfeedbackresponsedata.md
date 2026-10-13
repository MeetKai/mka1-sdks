# ListFeedbackResponseData

Feedback entry in a list, including the model that produced the rated output.

## Example Usage

```typescript
import { ListFeedbackResponseData } from "@meetkai/mka1/models/components";

let value: ListFeedbackResponseData = {
  id: "<id>",
  model: "Camry",
  createdAt: new Date("2024-02-09T12:38:37.240Z"),
  updatedAt: new Date("2025-02-07T21:00:31.113Z"),
};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `id`                                                                                           | *string*                                                                                       | :heavy_check_mark:                                                                             | The request ID that this feedback is associated with                                           |
| `rating`                                                                                       | [components.ListFeedbackResponseRating](../../models/components/listfeedbackresponserating.md) | :heavy_minus_sign:                                                                             | The feedback rating indicating user satisfaction                                               |
| `description`                                                                                  | *string*                                                                                       | :heavy_minus_sign:                                                                             | Optional detailed feedback description providing additional context or explanation             |
| `model`                                                                                        | *string*                                                                                       | :heavy_check_mark:                                                                             | The model that produced the rated output.                                                      |
| `createdAt`                                                                                    | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)  | :heavy_check_mark:                                                                             | ISO 8601 timestamp when the underlying output was created                                      |
| `updatedAt`                                                                                    | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)  | :heavy_check_mark:                                                                             | ISO 8601 timestamp when the underlying output record was last updated                          |