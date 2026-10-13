# EvalScheduleRunRequestConfig

## Example Usage

```typescript
import { EvalScheduleRunRequestConfig } from "@meetkai/mka1/models/components";

let value: EvalScheduleRunRequestConfig = {
  models: [
    "<value 1>",
    "<value 2>",
  ],
};
```

## Fields

| Field                                                                                            | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `models`                                                                                         | *string*[]                                                                                       | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `taskIds`                                                                                        | *string*[]                                                                                       | :heavy_minus_sign:                                                                               | N/A                                                                                              |
| `judgeModel`                                                                                     | *string*                                                                                         | :heavy_minus_sign:                                                                               | N/A                                                                                              |
| `embeddingModel`                                                                                 | *string*                                                                                         | :heavy_minus_sign:                                                                               | N/A                                                                                              |
| `generation`                                                                                     | [components.EvalGenerationRequestConfig](../../models/components/evalgenerationrequestconfig.md) | :heavy_minus_sign:                                                                               | N/A                                                                                              |
| `generationConcurrency`                                                                          | *number*                                                                                         | :heavy_minus_sign:                                                                               | N/A                                                                                              |
| `concurrency`                                                                                    | *number*                                                                                         | :heavy_minus_sign:                                                                               | N/A                                                                                              |
| `graderConcurrency`                                                                              | *number*                                                                                         | :heavy_minus_sign:                                                                               | N/A                                                                                              |
| `maxSamplesPerTask`                                                                              | *number*                                                                                         | :heavy_minus_sign:                                                                               | N/A                                                                                              |
| `maxWorkflowSampleActivities`                                                                    | *number*                                                                                         | :heavy_minus_sign:                                                                               | N/A                                                                                              |