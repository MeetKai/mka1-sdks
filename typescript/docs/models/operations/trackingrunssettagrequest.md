# TrackingRunsSetTagRequest

## Example Usage

```typescript
import { TrackingRunsSetTagRequest } from "@meetkai/mka1/models/operations";

let value: TrackingRunsSetTagRequest = {
  requestBody: {
    runId: "<id>",
    key: "<key>",
    value: "<value>",
  },
};
```

## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                        | *string*                                                                                             | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |
| `requestBody`                                                                                        | [operations.TrackingRunsSetTagRequestBody](../../models/operations/trackingrunssettagrequestbody.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |