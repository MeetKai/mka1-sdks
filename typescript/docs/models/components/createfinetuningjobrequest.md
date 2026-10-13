# CreateFineTuningJobRequest

## Example Usage

```typescript
import { CreateFineTuningJobRequest } from "@meetkai/mka1/models/components";

let value: CreateFineTuningJobRequest = {
  model: "CX-9",
  trainingFile: "<value>",
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `model`                                                                        | *string*                                                                       | :heavy_check_mark:                                                             | The base model to fine-tune                                                    |
| `trainingFile`                                                                 | *string*                                                                       | :heavy_check_mark:                                                             | File ID of the training data JSONL file                                        |
| `validationFile`                                                               | *string*                                                                       | :heavy_minus_sign:                                                             | File ID of the validation data JSONL file                                      |
| `suffix`                                                                       | *string*                                                                       | :heavy_minus_sign:                                                             | Suffix appended to the fine-tuned model name                                   |
| `seed`                                                                         | *number*                                                                       | :heavy_minus_sign:                                                             | Seed for reproducibility                                                       |
| `hyperparameters`                                                              | [components.Hyperparameters](../../models/components/hyperparameters.md)       | :heavy_minus_sign:                                                             | Deprecated: use method instead                                                 |
| `method`                                                                       | [components.Method](../../models/components/method.md)                         | :heavy_minus_sign:                                                             | Fine-tuning method configuration                                               |
| `integrations`                                                                 | [components.IntegrationObject](../../models/components/integrationobject.md)[] | :heavy_minus_sign:                                                             | External integrations                                                          |
| `metadata`                                                                     | Record<string, *string*>                                                       | :heavy_minus_sign:                                                             | Up to 16 key-value pairs                                                       |