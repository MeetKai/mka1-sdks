# UpdateEvalScheduleRun

Persisted schedule run configuration. Unknown stored fields remain readable without becoming supported execution controls.

## Example Usage

```typescript
import { UpdateEvalScheduleRun } from "@meetkai/mka1/models/operations";

let value: UpdateEvalScheduleRun = {
  models: [
    "<value 1>",
  ],
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `models`                                                                                           | *string*[]                                                                                         | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `taskIds`                                                                                          | *string*[]                                                                                         | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `judgeModel`                                                                                       | *string*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `embeddingModel`                                                                                   | *string*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `generation`                                                                                       | [operations.UpdateEvalScheduleGeneration](../../models/operations/updateevalschedulegeneration.md) | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `generationConcurrency`                                                                            | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `concurrency`                                                                                      | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `graderConcurrency`                                                                                | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `maxSamplesPerTask`                                                                                | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `maxWorkflowSampleActivities`                                                                      | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `additionalProperties`                                                                             | Record<string, *any*>                                                                              | :heavy_minus_sign:                                                                                 | N/A                                                                                                |