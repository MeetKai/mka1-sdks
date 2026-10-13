# ClassificationResponseData

The classification result data

## Example Usage

```typescript
import { ClassificationResponseData } from "@meetkai/mka1/models/components";

let value: ClassificationResponseData = {
  label: "<value>",
};
```

## Fields

| Field                                                                                                                                                     | Type                                                                                                                                                      | Required                                                                                                                                                  | Description                                                                                                                                               |
| --------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `label`                                                                                                                                                   | *string*                                                                                                                                                  | :heavy_check_mark:                                                                                                                                        | The label selected by the model from the provided options. This is the classification result.                                                             |
| `confidence`                                                                                                                                              | *number*                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                        | Optional confidence score between 0 and 1 indicating how confident the model is in its classification decision. Higher values indicate higher confidence. |
| `reasoning`                                                                                                                                               | *string*                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                        | Optional brief explanation from the model explaining why it chose this particular label. Provides transparency into the classification decision.          |