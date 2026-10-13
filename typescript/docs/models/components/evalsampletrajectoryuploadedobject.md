# EvalSampleTrajectoryUploadedObject

## Example Usage

```typescript
import { EvalSampleTrajectoryUploadedObject } from "@meetkai/mka1/models/components";

let value: EvalSampleTrajectoryUploadedObject = {
  object: "eval.sample.trajectory.uploaded",
  runId: "<id>",
  sampleIndex: 860784,
  taskId: "<id>",
  model: "Beetle",
  stepCount: 334499,
  sizeBytes: 161052,
};
```

## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `object`                                                                     | *"eval.sample.trajectory.uploaded"*                                          | :heavy_check_mark:                                                           | N/A                                                                          |
| `runId`                                                                      | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `sampleIndex`                                                                | *number*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `taskId`                                                                     | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `model`                                                                      | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `stepCount`                                                                  | *number*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `sizeBytes`                                                                  | *number*                                                                     | :heavy_check_mark:                                                           | Measured from the stored payload, so it describes what was actually written. |