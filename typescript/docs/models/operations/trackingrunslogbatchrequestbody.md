# TrackingRunsLogBatchRequestBody

## Example Usage

```typescript
import { TrackingRunsLogBatchRequestBody } from "@meetkai/mka1/models/operations";

let value: TrackingRunsLogBatchRequestBody = {
  runId: "<id>",
};
```

## Fields

| Field                                                    | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `runId`                                                  | *string*                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `metrics`                                                | [components.Metric](../../models/components/metric.md)[] | :heavy_minus_sign:                                       | N/A                                                      |
| `params`                                                 | [components.Param](../../models/components/param.md)[]   | :heavy_minus_sign:                                       | N/A                                                      |
| `tags`                                                   | [components.Tag](../../models/components/tag.md)[]       | :heavy_minus_sign:                                       | N/A                                                      |