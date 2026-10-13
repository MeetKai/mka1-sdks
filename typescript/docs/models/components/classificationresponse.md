# ClassificationResponse

Response from the text classification endpoint containing the classification result, confidence, and metadata.

## Example Usage

```typescript
import { ClassificationResponse } from "@meetkai/mka1/models/components";

let value: ClassificationResponse = {
  success: true,
  data: {
    label: "positive",
    confidence: 0.92,
    reasoning:
      "The text expresses strong enthusiasm with phrases like 'absolutely love' and 'best purchase ever'.",
  },
  metadata: {
    model: "meetkai:functionary-urdu-mini-pak",
    labels: [
      "positive",
      "negative",
      "neutral",
    ],
    classifiedAt: new Date("2024-01-15T10:30:00Z"),
  },
};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `success`                                                                                      | *boolean*                                                                                      | :heavy_check_mark:                                                                             | Indicates whether the classification request was successful                                    |
| `data`                                                                                         | [components.ClassificationResponseData](../../models/components/classificationresponsedata.md) | :heavy_check_mark:                                                                             | The classification result data                                                                 |
| `metadata`                                                                                     | [components.Metadata](../../models/components/metadata.md)                                     | :heavy_check_mark:                                                                             | Metadata about the classification request and execution                                        |