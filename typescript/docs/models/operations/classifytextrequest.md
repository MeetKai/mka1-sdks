# ClassifyTextRequest

## Example Usage

```typescript
import { ClassifyTextRequest } from "@meetkai/mka1/models/operations";

let value: ClassifyTextRequest = {
  classificationRequest: {
    model: "meetkai:functionary-urdu-mini-pak",
    text: "I absolutely love this product! Best purchase ever.",
    labels: [
      "positive",
      "negative",
      "neutral",
    ],
  },
};
```

## Fields

| Field                                                                                                                                                            | Type                                                                                                                                                             | Required                                                                                                                                                         | Description                                                                                                                                                      | Example                                                                                                                                                          |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                                                                                    | *string*                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                               | Optional external end-user identifier forwarded by the API gateway.                                                                                              |                                                                                                                                                                  |
| `classificationRequest`                                                                                                                                          | [components.ClassificationRequest](../../models/components/classificationrequest.md)                                                                             | :heavy_check_mark:                                                                                                                                               | N/A                                                                                                                                                              | {<br/>"model": "meetkai:functionary-urdu-mini-pak",<br/>"text": "I absolutely love this product! Best purchase ever.",<br/>"labels": [<br/>"positive",<br/>"negative",<br/>"neutral"<br/>]<br/>} |