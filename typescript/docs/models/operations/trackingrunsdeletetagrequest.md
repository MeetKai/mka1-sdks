# TrackingRunsDeleteTagRequest

## Example Usage

```typescript
import { TrackingRunsDeleteTagRequest } from "@meetkai/mka1/models/operations";

let value: TrackingRunsDeleteTagRequest = {
  requestBody: {
    runId: "<id>",
    key: "<key>",
  },
};
```

## Fields

| Field                                                                                                      | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                              | *string*                                                                                                   | :heavy_minus_sign:                                                                                         | Optional external end-user identifier forwarded by the API gateway.                                        |
| `requestBody`                                                                                              | [operations.TrackingRunsDeleteTagRequestBody](../../models/operations/trackingrunsdeletetagrequestbody.md) | :heavy_check_mark:                                                                                         | N/A                                                                                                        |