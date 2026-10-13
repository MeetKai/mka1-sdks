# TrackingRunsLogMetricRequest

## Example Usage

```typescript
import { TrackingRunsLogMetricRequest } from "@meetkai/mka1/models/operations";

let value: TrackingRunsLogMetricRequest = {
  requestBody: {
    runId: "<id>",
    key: "<key>",
    value: 4318.69,
    timestamp: 88002,
  },
};
```

## Fields

| Field                                                                                                      | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                              | *string*                                                                                                   | :heavy_minus_sign:                                                                                         | Optional external end-user identifier forwarded by the API gateway.                                        |
| `requestBody`                                                                                              | [operations.TrackingRunsLogMetricRequestBody](../../models/operations/trackingrunslogmetricrequestbody.md) | :heavy_check_mark:                                                                                         | N/A                                                                                                        |