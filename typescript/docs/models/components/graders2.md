# Graders2

## Example Usage

```typescript
import { Graders2 } from "@meetkai/mka1/models/components";

let value: Graders2 = {
  type: "text_similarity",
  name: "<value>",
  input: "<value>",
  reference: "<value>",
  evaluationMetric: "rouge_3",
};
```

## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `type`                                                                                   | *"text_similarity"*                                                                      | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `name`                                                                                   | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `input`                                                                                  | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `reference`                                                                              | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `evaluationMetric`                                                                       | [components.GradersEvaluationMetric](../../models/components/gradersevaluationmetric.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |