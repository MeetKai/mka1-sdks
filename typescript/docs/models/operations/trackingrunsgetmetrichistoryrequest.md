# TrackingRunsGetMetricHistoryRequest

## Example Usage

```typescript
import { TrackingRunsGetMetricHistoryRequest } from "@meetkai/mka1/models/operations";

let value: TrackingRunsGetMetricHistoryRequest = {
  runId: "<id>",
  metricKey: "<value>",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `runId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `metricKey`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `maxResults`                                                        | *number*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `pageToken`                                                         | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |