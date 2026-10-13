# FineTuningCheckpoint

## Example Usage

```typescript
import { FineTuningCheckpoint } from "@meetkai/mka1/models/components";

let value: FineTuningCheckpoint = {
  id: "<id>",
  object: "fine_tuning.job.checkpoint",
  createdAt: 119414,
  fineTunedModelCheckpoint: "<value>",
  fineTuningJobId: "<id>",
  stepNumber: 642149,
  metrics: {},
};
```

## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `id`                                                                         | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `object`                                                                     | *"fine_tuning.job.checkpoint"*                                               | :heavy_check_mark:                                                           | N/A                                                                          |
| `createdAt`                                                                  | *number*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `fineTunedModelCheckpoint`                                                   | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `fineTuningJobId`                                                            | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `stepNumber`                                                                 | *number*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `metrics`                                                                    | [components.CheckpointMetrics](../../models/components/checkpointmetrics.md) | :heavy_check_mark:                                                           | N/A                                                                          |