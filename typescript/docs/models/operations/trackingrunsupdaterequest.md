# TrackingRunsUpdateRequest

## Example Usage

```typescript
import { TrackingRunsUpdateRequest } from "@meetkai/mka1/models/operations";

let value: TrackingRunsUpdateRequest = {
  requestBody: {
    runId: "<id>",
  },
};
```

## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                        | *string*                                                                                             | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |
| `requestBody`                                                                                        | [operations.TrackingRunsUpdateRequestBody](../../models/operations/trackingrunsupdaterequestbody.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |