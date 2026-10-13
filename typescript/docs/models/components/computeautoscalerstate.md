# ComputeAutoscalerState

## Example Usage

```typescript
import { ComputeAutoscalerState } from "@meetkai/mka1/models/components";

let value: ComputeAutoscalerState = {
  blockedReason: "<value>",
  drainTimeoutSeconds: 950370,
  evaluationIntervalSeconds: 495728,
  lastScaleAt: new Date("2024-12-13T05:40:32.474Z"),
  observedAt: new Date("2026-08-16T00:53:04.681Z"),
  observedConcurrency: 151928,
  recommendedReplicas: 888595,
  status: "unknown",
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `blockedReason`                                                                                    | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `drainTimeoutSeconds`                                                                              | *number*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `evaluationIntervalSeconds`                                                                        | *number*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `lastScaleAt`                                                                                      | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)      | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `observedAt`                                                                                       | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)      | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `observedConcurrency`                                                                              | *number*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `recommendedReplicas`                                                                              | *number*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `status`                                                                                           | [components.ComputeAutoscalerStateStatus](../../models/components/computeautoscalerstatestatus.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |