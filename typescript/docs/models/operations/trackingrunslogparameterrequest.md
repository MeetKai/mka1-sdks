# TrackingRunsLogParameterRequest

## Example Usage

```typescript
import { TrackingRunsLogParameterRequest } from "@meetkai/mka1/models/operations";

let value: TrackingRunsLogParameterRequest = {
  requestBody: {
    runId: "<id>",
    key: "<key>",
    value: "<value>",
  },
};
```

## Fields

| Field                                                                                                            | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                                    | *string*                                                                                                         | :heavy_minus_sign:                                                                                               | Optional external end-user identifier forwarded by the API gateway.                                              |
| `requestBody`                                                                                                    | [operations.TrackingRunsLogParameterRequestBody](../../models/operations/trackingrunslogparameterrequestbody.md) | :heavy_check_mark:                                                                                               | N/A                                                                                                              |