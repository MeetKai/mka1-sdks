# TrackingRunsCreateRequest

## Example Usage

```typescript
import { TrackingRunsCreateRequest } from "@meetkai/mka1/models/operations";

let value: TrackingRunsCreateRequest = {
  requestBody: {
    experimentId: "<id>",
  },
};
```

## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                        | *string*                                                                                             | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |
| `requestBody`                                                                                        | [operations.TrackingRunsCreateRequestBody](../../models/operations/trackingrunscreaterequestbody.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |