# TrackingExperimentsDeleteRequest

## Example Usage

```typescript
import { TrackingExperimentsDeleteRequest } from "@meetkai/mka1/models/operations";

let value: TrackingExperimentsDeleteRequest = {
  requestBody: {
    experimentId: "<id>",
  },
};
```

## Fields

| Field                                                                                                              | Type                                                                                                               | Required                                                                                                           | Description                                                                                                        |
| ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ |
| `xOnBehalfOf`                                                                                                      | *string*                                                                                                           | :heavy_minus_sign:                                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                                |
| `requestBody`                                                                                                      | [operations.TrackingExperimentsDeleteRequestBody](../../models/operations/trackingexperimentsdeleterequestbody.md) | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |