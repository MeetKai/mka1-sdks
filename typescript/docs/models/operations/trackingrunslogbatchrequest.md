# TrackingRunsLogBatchRequest

## Example Usage

```typescript
import { TrackingRunsLogBatchRequest } from "@meetkai/mka1/models/operations";

let value: TrackingRunsLogBatchRequest = {
  requestBody: {
    runId: "<id>",
  },
};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                            | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                      |
| `requestBody`                                                                                            | [operations.TrackingRunsLogBatchRequestBody](../../models/operations/trackingrunslogbatchrequestbody.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |