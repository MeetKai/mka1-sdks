# One2

## Example Usage

```typescript
import { One2 } from "@meetkai/mka1/models/components";

let value: One2 = {
  type: "text_similarity",
  name: "<value>",
  input: "<value>",
  reference: "<value>",
  evaluationMetric: "rouge_5",
};
```

## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `type`                                                                     | *"text_similarity"*                                                        | :heavy_check_mark:                                                         | N/A                                                                        |
| `name`                                                                     | *string*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `input`                                                                    | *string*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `reference`                                                                | *string*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `evaluationMetric`                                                         | [components.EvaluationMetric](../../models/components/evaluationmetric.md) | :heavy_check_mark:                                                         | N/A                                                                        |