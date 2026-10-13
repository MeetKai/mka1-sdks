# ComputeScalingReplicas

## Example Usage

```typescript
import { ComputeScalingReplicas } from "@meetkai/mka1/models/components";

let value: ComputeScalingReplicas = {
  allocated: 470280,
  applied: 980158,
  appliedGeneration: 563051,
  decision: "create",
  desired: 377919,
  desiredGeneration: 931044,
  draining: 994243,
  ready: 498593,
  updatedAt: new Date("2025-11-04T14:52:49.242Z"),
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `allocated`                                                                                   | *number*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `applied`                                                                                     | *number*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `appliedGeneration`                                                                           | *number*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `decision`                                                                                    | [components.Decision](../../models/components/decision.md)                                    | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `desired`                                                                                     | *number*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `desiredGeneration`                                                                           | *number*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `draining`                                                                                    | *number*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `ready`                                                                                       | *number*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `updatedAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |