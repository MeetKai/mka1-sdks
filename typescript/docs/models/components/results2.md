# Results2

Feedback object containing user ratings and comments about a chat completion or response.

## Example Usage

```typescript
import { Results2 } from "@meetkai/mka1/models/components";

let value: Results2 = {
  id: "<id>",
};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                     | *string*                                                                                                 | :heavy_check_mark:                                                                                       | The request ID that this feedback is associated with                                                     |
| `rating`                                                                                                 | [components.ResultsRating](../../models/components/resultsrating.md)                                     | :heavy_minus_sign:                                                                                       | The feedback rating indicating user satisfaction                                                         |
| `description`                                                                                            | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | Optional detailed feedback description providing additional context or explanation (max 2000 characters) |
| `createdAt`                                                                                              | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)            | :heavy_minus_sign:                                                                                       | ISO 8601 timestamp when the underlying output was created                                                |
| `updatedAt`                                                                                              | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)            | :heavy_minus_sign:                                                                                       | ISO 8601 timestamp when the underlying output record was last updated                                    |