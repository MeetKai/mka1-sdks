# ComputeServiceScaling

## Example Usage

```typescript
import { ComputeServiceScaling } from "@meetkai/mka1/models/components";

let value: ComputeServiceScaling = {
  applied: {
    maxReplicas: 37610,
    minReplicas: 268736,
  },
  appliedAt: new Date("2026-08-06T21:55:46.186Z"),
  appliedGeneration: 764652,
  autoscaler: {
    blockedReason: "<value>",
    drainTimeoutSeconds: 675212,
    evaluationIntervalSeconds: 666075,
    lastScaleAt: new Date("2024-07-15T11:08:01.509Z"),
    observedAt: new Date("2026-01-22T17:31:12.091Z"),
    observedConcurrency: 678448,
    recommendedReplicas: 126386,
    status: "active",
  },
  desired: {
    maxReplicas: 768429,
    minReplicas: 979438,
  },
  desiredGeneration: 760619,
  desiredUpdatedAt: new Date("2026-05-26T03:33:59.955Z"),
  replicas: {
    allocated: 823617,
    applied: 578263,
    appliedGeneration: 639235,
    decision: "autoscaler",
    desired: 956316,
    desiredGeneration: 140136,
    draining: 27745,
    ready: 380246,
    updatedAt: new Date("2025-10-08T07:00:02.517Z"),
  },
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `applied`                                                                                     | [components.ComputeScalingInput](../../models/components/computescalinginput.md)              | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `appliedAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `appliedGeneration`                                                                           | *number*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `autoscaler`                                                                                  | [components.ComputeAutoscalerState](../../models/components/computeautoscalerstate.md)        | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `desired`                                                                                     | [components.ComputeScalingInput](../../models/components/computescalinginput.md)              | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `desiredGeneration`                                                                           | *number*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `desiredUpdatedAt`                                                                            | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `replicas`                                                                                    | [components.ComputeScalingReplicas](../../models/components/computescalingreplicas.md)        | :heavy_check_mark:                                                                            | N/A                                                                                           |