# TrackingRunsRestoreRequest

## Example Usage

```typescript
import { TrackingRunsRestoreRequest } from "@meetkai/mka1/models/operations";

let value: TrackingRunsRestoreRequest = {
  requestBody: {
    runId: "<id>",
  },
};
```

## Fields

| Field                                                                                                  | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `xOnBehalfOf`                                                                                          | *string*                                                                                               | :heavy_minus_sign:                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                    |
| `requestBody`                                                                                          | [operations.TrackingRunsRestoreRequestBody](../../models/operations/trackingrunsrestorerequestbody.md) | :heavy_check_mark:                                                                                     | N/A                                                                                                    |