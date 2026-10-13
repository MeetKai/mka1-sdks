# ClassificationRequest

Request parameters for text classification. The model will analyze the text and assign it to one of the provided labels.

## Example Usage

```typescript
import { ClassificationRequest } from "@meetkai/mka1/models/components";

let value: ClassificationRequest = {
  model: "meetkai:functionary-urdu-mini-pak",
  text: "I absolutely love this product! Best purchase ever.",
  labels: [
    "positive",
    "negative",
    "neutral",
  ],
};
```

## Fields

| Field                                                                                                                                                                   | Type                                                                                                                                                                    | Required                                                                                                                                                                | Description                                                                                                                                                             |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `model`                                                                                                                                                                 | *string*                                                                                                                                                                | :heavy_check_mark:                                                                                                                                                      | ID of the model to use for classification. You can use provider:model format or just the model name with a default provider.                                            |
| `text`                                                                                                                                                                  | *string*                                                                                                                                                                | :heavy_check_mark:                                                                                                                                                      | The text content to classify. Must not be empty.                                                                                                                        |
| `labels`                                                                                                                                                                | *string*[]                                                                                                                                                              | :heavy_check_mark:                                                                                                                                                      | Array of possible classification labels. Must contain at least 2 labels. The model will choose one of these labels to assign to the text.                               |
| `prompt`                                                                                                                                                                | *string*                                                                                                                                                                | :heavy_minus_sign:                                                                                                                                                      | Optional custom system prompt to guide the classification. Use this to provide additional context or instructions to the model about how to perform the classification. |