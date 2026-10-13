# TrackingRunsLogInputsRequest

## Example Usage

```typescript
import { TrackingRunsLogInputsRequest } from "@meetkai/mka1/models/operations";

let value: TrackingRunsLogInputsRequest = {
  requestBody: {
    runId: "<id>",
    datasets: [],
  },
};
```

## Fields

| Field                                                                                                      | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                              | *string*                                                                                                   | :heavy_minus_sign:                                                                                         | Optional external end-user identifier forwarded by the API gateway.                                        |
| `requestBody`                                                                                              | [operations.TrackingRunsLogInputsRequestBody](../../models/operations/trackingrunsloginputsrequestbody.md) | :heavy_check_mark:                                                                                         | N/A                                                                                                        |