# TrackingRunsDeleteRequest

## Example Usage

```typescript
import { TrackingRunsDeleteRequest } from "@meetkai/mka1/models/operations";

let value: TrackingRunsDeleteRequest = {
  requestBody: {
    runId: "<id>",
  },
};
```

## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                        | *string*                                                                                             | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |
| `requestBody`                                                                                        | [operations.TrackingRunsDeleteRequestBody](../../models/operations/trackingrunsdeleterequestbody.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |