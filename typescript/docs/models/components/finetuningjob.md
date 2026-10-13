# FineTuningJob

## Example Usage

```typescript
import { FineTuningJob } from "@meetkai/mka1/models/components";

let value: FineTuningJob = {
  id: "<id>",
  object: "fine_tuning.job",
  createdAt: 775686,
  model: "Countach",
  trainingFile: "<value>",
  organizationId: "<id>",
  status: "cancelled",
  resultFiles: [
    "<value 1>",
    "<value 2>",
  ],
  seed: 591160,
  hyperparameters: {},
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `id`                                                                                               | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `object`                                                                                           | *"fine_tuning.job"*                                                                                | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `createdAt`                                                                                        | *number*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `model`                                                                                            | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `trainingFile`                                                                                     | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `validationFile`                                                                                   | *string*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `fineTunedModel`                                                                                   | *string*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `organizationId`                                                                                   | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `status`                                                                                           | [components.JobStatus](../../models/components/jobstatus.md)                                       | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `resultFiles`                                                                                      | *string*[]                                                                                         | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `seed`                                                                                             | *number*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `hyperparameters`                                                                                  | [components.FineTuningJobHyperparameters](../../models/components/finetuningjobhyperparameters.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `method`                                                                                           | [components.Method](../../models/components/method.md)                                             | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `finishedAt`                                                                                       | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `estimatedFinish`                                                                                  | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `trainedTokens`                                                                                    | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `error`                                                                                            | [components.FineTuningError](../../models/components/finetuningerror.md)                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `integrations`                                                                                     | [components.IntegrationObject](../../models/components/integrationobject.md)[]                     | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `metadata`                                                                                         | Record<string, *string*>                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `suffix`                                                                                           | *string*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |