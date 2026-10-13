# TrackingRunsSearchRequest

## Example Usage

```typescript
import { TrackingRunsSearchRequest } from "@meetkai/mka1/models/operations";

let value: TrackingRunsSearchRequest = {
  requestBody: {
    experimentIds: [
      "<value 1>",
    ],
  },
};
```

## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                        | *string*                                                                                             | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |
| `requestBody`                                                                                        | [operations.TrackingRunsSearchRequestBody](../../models/operations/trackingrunssearchrequestbody.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |