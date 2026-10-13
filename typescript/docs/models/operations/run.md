# Run

Persisted schedule run configuration. Unknown stored fields remain readable without becoming supported execution controls.

## Example Usage

```typescript
import { Run } from "@meetkai/mka1/models/operations";

let value: Run = {
  models: [
    "<value 1>",
    "<value 2>",
    "<value 3>",
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
| `generation`                                                                                       | [operations.CreateEvalScheduleGeneration](../../models/operations/createevalschedulegeneration.md) | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `generationConcurrency`                                                                            | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `concurrency`                                                                                      | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `graderConcurrency`                                                                                | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `maxSamplesPerTask`                                                                                | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `maxWorkflowSampleActivities`                                                                      | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `additionalProperties`                                                                             | Record<string, *any*>                                                                              | :heavy_minus_sign:                                                                                 | N/A                                                                                                |